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
        PaginationResponse<CountryDto> Get(CountryRequest model);
        Country Add(CountryViewModel model);
        Country Edit(CountryViewModel model);
        void Delete(int id);
    }
}
