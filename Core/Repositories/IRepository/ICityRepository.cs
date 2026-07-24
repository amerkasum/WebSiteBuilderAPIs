using Domain.DTO;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface ICityRepository : IRepository<City>
    {
        IEnumerable<LocationDto> GetAll();
        bool DoesCityExist(string name, string pttCode);
        City GetByName(string name);

    }
}
