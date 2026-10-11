using Azure.Core;
using Core.EF;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
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
        private readonly ApplicationDbContext ApplicationDbContext;
        private readonly AuditDbContext AuditDbContext;
        private readonly ILoggedUser LoggedUser;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public AuditLogService(ApplicationDbContext applicationDbContext, AuditDbContext auditDbContext,
            ILoggedUser loggedUser, IHttpContextAccessor httpContextAccessor)
        {
            this.ApplicationDbContext = applicationDbContext;
            this.AuditDbContext = auditDbContext;
            this.LoggedUser = loggedUser;
            this.HttpContextAccessor = httpContextAccessor;
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
                    UserId = LoggedUser.UserId?.ToString(),
                    Controller = context?.GetRouteData().Values["controller"]?.ToString(),
                    Method = context?.GetEndpoint()?.Metadata.GetMetadata<ControllerActionDescriptor>()?.ActionName,
                    HttpMethod = request?.Method,
                    BrowserInfo = request?.Headers.UserAgent.ToString(),
                    Url = request == null ? null: $"{request.Path}{request.QueryString}",
                    QueryParameters = request?.QueryString.ToString(),
                    Table = entityType.GetTableName(),
                    EntityId = entityId
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
