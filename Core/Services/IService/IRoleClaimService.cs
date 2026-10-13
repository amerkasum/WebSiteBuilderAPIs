using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IRoleClaimService
    {
        Task<IEnumerable<RoleClaimDto>> GetAsync(RoleClaimRequest model);
        Task<RoleClaim> AddAsync(RoleClaimViewModel model);
        Task<RoleClaim> EditAsync(RoleClaimViewModel model);
        Task DeleteAsync(int id);
    }
}
