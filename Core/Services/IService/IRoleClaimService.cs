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
        IEnumerable<RoleClaimDto> Get(RoleClaimRequest model);
        RoleClaim Add(RoleClaimViewModel model);
        RoleClaim Edit(RoleClaimViewModel model);
        void Delete(int id);
    }
}
