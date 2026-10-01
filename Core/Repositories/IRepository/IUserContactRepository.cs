using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IUserContactRepository : IRepository<UserContact>
    {
        IEnumerable<UserContactDto> Get(UserContactRequest model);
    }
}
