using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Pagination;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IAuditLogService AuditLogService;
        public UserRoleService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<PaginationResponse<UserRoleDto>> GetAsync(UserRoleRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.UserRole.GetAsync(model);
        }
        public async Task<UserRole> AddAsync(UserRoleViewModel model)
        {
            var userRole = new UserRole
            {
                UserId = model.UserId,
                RoleId = model.RoleId
            };

            UnitOfWork.UserRole.Add(userRole);
            await UnitOfWork.SaveChangesAsync();

            return userRole;
        }

        public async Task<UserRole> EditAsync(UserRoleViewModel model)
        {
            var userRole = UnitOfWork.UserRole.GetById(model.Id);

            if (userRole == null)
                throw new KeyNotFoundException();

            userRole.UserId = model.UserId;
            userRole.RoleId = model.RoleId;

            UnitOfWork.UserRole.Update(userRole);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return userRole;
        }

        public async Task DeleteAsync(int id)
        {
            var userRole = UnitOfWork.UserRole.GetById(id);

            if (userRole == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserRole.Remove(userRole);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }

    }
}
