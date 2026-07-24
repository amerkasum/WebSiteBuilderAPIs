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
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<LocationDto> GetAll()
        {
            return _context.Cities.Include(x => x.Region).ThenInclude(x => x.Country)
                .Where(x => x.RegionId == x.Region.Id && x.Region.CountryId == x.Region.Country.Id)
                .Select(x => new LocationDto
            {
                CityName = x.Name,
                PttCode = x.PttCode,
                Region = x.Region.Name,
                Country = x.Region.Country.Name,
                CountryIso = x.Region.Country.Iso
            }).AsEnumerable();
        }

        public bool DoesCityExist(string name, string pttCode)
        {
            return _context.Cities.Any(x => x.Name.ToLower().Equals(name.ToLower()) && x.PttCode.ToLower().Equals(pttCode));
        }

        public City GetByName(string name)
        {
            return _context.Cities.FirstOrDefault(x => x.Name.ToLower().Equals(name.ToLower()));
        }
    }
}
