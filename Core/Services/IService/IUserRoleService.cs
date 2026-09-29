using Domain.DTO;
using Domain.Entities.Personal;
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
        IEnumerable<UserRoleDto> Get(UserRoleRequest model);
        UserRole Add(UserRoleViewModel model);
        UserRole Edit(UserRoleViewModel model);
        void Delete(int id);
    }
}
