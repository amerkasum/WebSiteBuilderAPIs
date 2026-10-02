using Core.EF;
using Core.EF.Seed;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<RegionDto>> Get(RegionRequest model)
        {
            var cities = await _context.Cities.Include(x => x.Region).ThenInclude(x => x.Country)
                .Where(x => (!model.CountryId.HasValue || x.Region.Country.Id == x.Id)).ToListAsync();

            var result = await _context.Regions.Include(x => x.Country)
                .Where(x => (string.IsNullOrEmpty(model.Search) || x.Name.Contains(model.Search))
                && (!model.CountryId.HasValue || model.CountryId == x.Country.Id))
                .Select(x => new RegionDto
                {
                    Id = x.Id,
                    CountryId = x.Country.Id,
                    Region = $"{x.Name}, {x.Country.Name}",
                    CitiesCount = cities.Where(x => x.RegionId == x.Id).Count()
                }).ToListAsync();

            return result;
        }

        public IEnumerable<Region> GetByCountryId(int countryId)
        {
            return _context.Regions.Where(x => x.CountryId == countryId).ToList();
        }
    }
}
