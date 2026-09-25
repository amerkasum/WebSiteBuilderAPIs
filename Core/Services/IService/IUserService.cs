using Domain.DTO;
using Domain.Entities.Personal;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetUsersWithParameters(string fullName);
        User Add(UserViewModel model);
    }
}
