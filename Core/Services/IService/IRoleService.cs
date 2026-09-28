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
    public interface IRoleService
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        Role Add(RoleViewModel model);
        Role Edit(RoleViewModel model);
        void Delete(int id);
    }
}
