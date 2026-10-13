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
    public interface ICityService
    {
        Task<PaginationResponse<CityDto>> GetAsync(CityRequest model);
        Task<City> AddAsync(CityViewModel model);
        Task<City> EditAsync(CityViewModel model);
        Task DeleteAsync(int id);
    }
}
