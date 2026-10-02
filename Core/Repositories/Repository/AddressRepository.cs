using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Requests;
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

        public bool DoesAddressExist(string name, int cityId)
        {
            return _context.Addresses.Any(x => x.Name.ToLower().Equals(name.ToLower()) && x.CityId == cityId);
        }

        public IEnumerable<LocationDto> Get(BasicSearchRequest model)
        {
            var result = _context.Addresses.Include(x => x.City).ThenInclude(x => x.Region).ThenInclude(x => x.Country)
                .Where(x => (string.IsNullOrEmpty(model.Search) || (x.Name.Contains(model.Search) || x.City.Name.Contains(model.Search) ||
                            x.City.Region.Name.Contains(model.Search) || x.City.Region.Country.Name.Contains(model.Search))) &&
                            (!x.IsDeleted && x.City.RegionId == x.City.Region.Id && x.City.Region.CountryId == x.City.Region.Country.Id))
                .Select(x => new LocationDto
                {
                    Id = x.Id,
                    AddressName = x.Name,
                    CityName = x.City.Name,
                    PttCode = x.City.PttCode,
                    Region = x.City.Region.Name,
                    Country = x.City.Region.Country.Name,
                    CountryIso = x.City.Region.Country.Iso
                }).AsEnumerable();
            return result;
        }
    }
}
