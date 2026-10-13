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
    public interface ICountryService
    {
        Task<PaginationResponse<CountryDto>> GetAsync(CountryRequest model);
        Task<Country> AddAsync(CountryViewModel model);
        Task<Country> EditAsync(CountryViewModel model);
        Task DeleteAsync(int id);
    }
}
