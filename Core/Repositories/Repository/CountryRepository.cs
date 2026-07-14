using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
