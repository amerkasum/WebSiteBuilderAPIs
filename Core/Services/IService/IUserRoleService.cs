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

namespace Core.Services.IService
{
    public interface IUserRoleService
    {
        Task<PaginationResponse<UserRoleDto>> GetAsync(UserRoleRequest model);
        Task<UserRole> AddAsync(UserRoleViewModel model);
        Task<UserRole> EditAsync(UserRoleViewModel model);
        Task DeleteAsync(int id);
    }
}
