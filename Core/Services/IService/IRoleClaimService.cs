using Domain.Entities.System;
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
        RoleClaim Add(RoleClaimViewModel model);
        RoleClaim Edit(RoleClaimViewModel model);
        void Delete(int id);
    }
}
