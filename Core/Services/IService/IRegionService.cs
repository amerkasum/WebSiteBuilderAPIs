using Domain.DTO;
using Domain.Entities.Location;
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
    public interface IRegionService
    {
        Task<PaginationResponse<RegionDto>> GetAsync(RegionRequest model);
        Task<Region> AddAsync(RegionViewModel model);
        Task<Region> EditAsync(RegionViewModel model);
        Task DeleteAsync(int id);
    }
}
