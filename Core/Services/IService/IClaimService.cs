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
    public interface IClaimService
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        Claim Add(ClaimViewModel model);
        Claim Edit(ClaimViewModel model);
        void Delete(int id);
    }
}
