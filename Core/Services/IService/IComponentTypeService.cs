using Domain.Entities.WebSiteBuilder;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IComponentTypeService
    {
        ComponentType Add(ComponentTypeViewModel model);
        ComponentType Edit(ComponentTypeViewModel model);
        void Delete(int id);
    }
}
