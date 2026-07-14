using Core.EF;
using Core.EF.Seed;
using Core.Repositories.IRepository;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Region> GetByCountryId(int countryId)
        {
            return _context.Regions.Where(x => x.CountryId == countryId).ToList();
        }
    }
}
