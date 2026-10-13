using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IAuditLogService AuditLogService;
        public RoleService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.Role.GetAsync(model);
            return result;
        }

        public async Task<Role> AddAsync(RoleViewModel model)
        {
            var role = new Role
            {
                Name = model.Code,
                Code = model.Code,
                Description = model.Description
            };

            UnitOfWork.Role.Add(role);
            await UnitOfWork.SaveChangesAsync();

            return role;
        }

        public async Task<Role> EditAsync(RoleViewModel model)
        {
            var role = UnitOfWork.Role.GetById(model.Id);

            if (role == null)
                throw new KeyNotFoundException();

            role.Name = model.Name;
            role.Code = model.Code;
            role.Description = model.Description;

            UnitOfWork.Role.Update(role);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return role;
        }

        public async Task DeleteAsync(int id)
        {
            var role = UnitOfWork.Role.GetById(id);

            if (role == null)
                throw new KeyNotFoundException();

            UnitOfWork.Role.Remove(role);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
