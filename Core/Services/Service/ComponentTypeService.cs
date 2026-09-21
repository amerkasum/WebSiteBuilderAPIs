using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.WebSiteBuilder;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ComponentTypeService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public ComponentType Add(ComponentTypeViewModel model)
        {
            var componentType = new ComponentType
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.ComponentType.Add(componentType);
            UnitOfWork.SaveChanges();

            return componentType;
        }

        public ComponentType Edit(ComponentTypeViewModel model)
        {
            var componentType = UnitOfWork.ComponentType.GetById(model.Id);

            if (componentType == null)
                throw new KeyNotFoundException();

            componentType.Name = model.Name;
            componentType.Code = model.Code;

            UnitOfWork.ComponentType.Update(componentType);
            UnitOfWork.SaveChanges();

            return componentType;
        }

        public void Delete(int id)
        {
            var componentType = UnitOfWork.ComponentType.GetById(id);

            if (componentType == null)
                throw new KeyNotFoundException();

            UnitOfWork.ComponentType.Remove(componentType);
            UnitOfWork.SaveChanges();
        }
    }
}
