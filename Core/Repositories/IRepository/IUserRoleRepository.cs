using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.Pagination;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        Task<PaginationResponse<UserRoleDto>> GetAsync(UserRoleRequest model);
    }
}
