using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetByUserId(int userId);
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
    }
}
