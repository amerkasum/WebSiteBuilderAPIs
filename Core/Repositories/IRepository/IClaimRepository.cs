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
    public interface IClaimRepository :IRepository<Claim>
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
    }
}
