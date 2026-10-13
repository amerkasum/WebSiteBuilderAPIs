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
    public interface IBusinessTypeService
    {
        Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<BusinessType> AddAsync(BusinessTypeViewModel model);
        Task<BusinessType> EditAsync(BusinessTypeViewModel model);
        Task DeleteAsync(int id);
    }
}
