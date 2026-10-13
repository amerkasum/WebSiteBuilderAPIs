using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface ICountryRepository : IRepository<Country>
    {
        Task<PaginationResponse<CountryDto>> GetAsync(CountryRequest model);
    }
}
