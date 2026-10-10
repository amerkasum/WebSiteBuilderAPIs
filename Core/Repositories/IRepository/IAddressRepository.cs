using Domain.DTO;
using Domain.Entities.Location;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAddressRepository : IRepository<Address>
    {
        bool DoesAddressExist(string name, int cityId);
        IEnumerable<AddressDto> Get(BasicSearchRequest model);
    }
}
