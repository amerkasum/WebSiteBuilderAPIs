using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AuthEventTypeService : IAuthEventTypeService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IAuditLogService AuditLogService;
        public AuthEventTypeService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<IEnumerable<AuthEventTypeDto>> GetAsync(AuthEventTypeRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.AuthEventType.GetAsync(model);
        }

        public async Task<AuthEventType> AddAsync(AuthEventTypeViewModel model)
        {
            var authEventType = new AuthEventType
            {
                Name = model.Name,
                Code = model.Code,
                Description = model.Description
            };

            UnitOfWork.AuthEventType.Add(authEventType);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return authEventType;
        }

        public async Task<AuthEventType> EditAsync(AuthEventTypeViewModel model)
        {
            var authEventType = await UnitOfWork.AuthEventType.GetByIdAsync(model.Id);

            if (authEventType == null)
                throw new KeyNotFoundException();

            authEventType.Name = model.Name;
            authEventType.Code = model.Code;
            authEventType.Description = model.Description;

            UnitOfWork.AuthEventType.Update(authEventType);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return authEventType;
        }

        public async Task DeleteAsync(int id)
        {
            var authEventType = await UnitOfWork.AuthEventType.GetByIdAsync(id);

            if (authEventType == null)
                throw new KeyNotFoundException();

            UnitOfWork.AuthEventType.Remove(authEventType);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
