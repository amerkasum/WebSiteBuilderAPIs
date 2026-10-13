using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
using Domain.Pagination;
using Domain.Requests;
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

        public async Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.ComponentType.GetAsync(model);
            return result;
        }

        public async Task<ComponentType> AddAsync(ComponentTypeViewModel model)
        {
            var componentType = new ComponentType
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.ComponentType.Add(componentType);
            await UnitOfWork.SaveChangesAsync();

            return componentType;
        }

        public async Task<ComponentType> EditAsync(ComponentTypeViewModel model)
        {
            var componentType = UnitOfWork.ComponentType.GetById(model.Id);

            if (componentType == null)
                throw new KeyNotFoundException();

            componentType.Name = model.Name;
            componentType.Code = model.Code;

            UnitOfWork.ComponentType.Update(componentType);
            await UnitOfWork.SaveChangesAsync();

            return componentType;
        }

        public async Task DeleteAsync(int id)
        {
            var componentType = UnitOfWork.ComponentType.GetById(id);

            if (componentType == null)
                throw new KeyNotFoundException();

            UnitOfWork.ComponentType.Remove(componentType);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
