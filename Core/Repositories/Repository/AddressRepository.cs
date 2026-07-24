using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<LocationDto> GetAll()
        {
            return _context.Addresses.Include(x => x.City).ThenInclude(x => x.Region).ThenInclude(x => x.Country)
                .Where(x => x.City.RegionId == x.City.Region.Id && x.City.Region.CountryId == x.City.Region.Country.Id)
                .Select(x => new LocationDto
                {
                    AddressName = x.Name,
                    CityName = x.City.Name,
                    PttCode = x.City.PttCode,
                    Region = x.City.Region.Name,
                    Country = x.City.Region.Country.Name,
                    CountryIso = x.City.Region.Country.Iso
                }).AsEnumerable();
        }

        public bool DoesAddressExist(string name)
        {
            return _context.Addresses.Any(x => x.Name.ToLower().Equals(name.ToLower()));
        }
    }
}
