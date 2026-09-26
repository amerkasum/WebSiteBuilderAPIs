using Domain.DTO;
using Domain.Entities.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        List<UserDto> GetUsersWithParameters(string fullName);
        bool DoesEmailAlreadyExist(string email);
        User GetByEmail(string email);
    }
}
