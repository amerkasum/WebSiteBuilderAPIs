using Domain.Entities.WebSiteBuilder;
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
        BusinessType Add(BusinessTypeViewModel model);
        BusinessType Edit(BusinessTypeViewModel model);
        void Delete(int id);
    }
}
