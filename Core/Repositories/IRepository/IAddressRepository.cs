using Domain.DTO;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<LocationDto> GetAll();
        bool DoesAddressExist(string name);
    }
}
