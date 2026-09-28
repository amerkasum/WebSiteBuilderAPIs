using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IBusinessTypeService
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        BusinessType Add(BusinessTypeViewModel model);
        BusinessType Edit(BusinessTypeViewModel model);
        void Delete(int id);
    }
}
