using Azure.Core;
using Core.EF;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Entities.System;
using Domain.Pagination;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AuditLogService : IAuditLogService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly ApplicationDbContext ApplicationDbContext;
        private readonly LogsDbContext AuditDbContext;
        private readonly ILoggedUser LoggedUser;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public AuditLogService(IUnitOfWork unitOfWork, ApplicationDbContext applicationDbContext, LogsDbContext auditDbContext,
            ILoggedUser loggedUser, IHttpContextAccessor httpContextAccessor)
        {
            this.UnitOfWork = unitOfWork;
            this.ApplicationDbContext = applicationDbContext;
            this.AuditDbContext = auditDbContext;
            this.LoggedUser = loggedUser;
            this.HttpContextAccessor = httpContextAccessor;
        }

        public async Task<PaginationResponse<AuditLogDto>> GetAsync(AuditLogRequest model)
        {
            var results = await UnitOfWork.AuditLog.Get(model);

            if (results == null || !results.Data.Any())
                return new PaginationResponse<AuditLogDto>();

            var userIds = results.Data.Select(x => x.User.Id).Distinct().ToList();         

            var users = await UnitOfWork.User.GetByIdsAsync(userIds);

            var userDictionary = users.ToDictionary(x => x.Id);

            foreach (var auditLog in results.Data)
            {
                if (userDictionary.TryGetValue(auditLog.User.Id, out var user))
                {
                    auditLog.User.Email = user.Email;
                    auditLog.User.FullName = user.FullName;
                    auditLog.User.Username = user.Username;
                }
            }

            return results;
        }

        public async Task Logger()
        {
            var context = HttpContextAccessor.HttpContext;
            var request = context?.Request;

            var entries = ApplicationDbContext.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified ||
                x.State == EntityState.Deleted).ToList();

            foreach (var entry in entries)
            {
                var entityType = entry.Metadata;
                var primaryKey = entityType.FindPrimaryKey();

                var entityId = primaryKey == null ? null : string.Join(", ", primaryKey.Properties.Select(p => entry.Property(p.Name).OriginalValue?.ToString()));

                var auditLog = new AuditLog
                {
                    UserId = LoggedUser.UserId,
                    Controller = context?.GetRouteData().Values["controller"]?.ToString(),
                    Method = context?.GetEndpoint()?.Metadata.GetMetadata<ControllerActionDescriptor>()?.ActionName,
                    HttpMethod = request?.Method,
                    BrowserInfo = request?.Headers.UserAgent.ToString(),
                    Url = request == null ? null: $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}",
                    QueryParameters = request?.QueryString.ToString(),
                    Table = entityType.GetTableName(),
                    EntityId = int.TryParse(entityId, out int id) ? id : 0
                };

                AuditDbContext.AuditLog.Add(auditLog);
                await AuditDbContext.SaveChangesAsync();

                foreach (var property in entry.Properties)
                {
                    if (property.Metadata.Name == "ModifiedDateTime" || property.Metadata.Name == "DeletedDateTime")
                        continue;

                    if (!property.IsModified)
                        continue;

                    var oldValue = property.OriginalValue?.ToString();
                    var newValue = property.CurrentValue?.ToString();

                    if (oldValue == newValue)
                        continue;

                    AuditDbContext.AuditLogEntityPropertyChange.Add(
                        new AuditLogEntityPropertyChange
                        {
                            Property = property.Metadata.Name,
                            OldValue = oldValue,
                            NewValue = newValue,
                            AuditLogId = auditLog.Id,
                        });
                }
            }
            await AuditDbContext.SaveChangesAsync();
        }
    }
}
