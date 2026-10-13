using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
using Domain.Pagination;
using Domain.Requests;
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
        Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<ComponentType> AddAsync(ComponentTypeViewModel model);
        Task<ComponentType> EditAsync(ComponentTypeViewModel model);
        Task DeleteAsync(int id);
    }
}
