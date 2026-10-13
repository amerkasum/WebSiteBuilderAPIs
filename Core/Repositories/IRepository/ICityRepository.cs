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
    public interface ICityRepository : IRepository<City>
    {
        Task<PaginationResponse<CityDto>> GetAsync(CityRequest model);
        bool DoesCityExist(string name, string pttCode);
        City GetByName(string name);

    }
}
