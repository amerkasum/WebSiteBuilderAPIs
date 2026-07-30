using Domain.DTO;
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
    }
}
