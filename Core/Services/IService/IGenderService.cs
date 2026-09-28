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
    public interface IGenderService
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        Gender Add(GenderViewModel model);
        Gender Edit(GenderViewModel model);
        void Delete(int id);
    }
}
