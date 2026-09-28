using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<CurrencyDto> Get(BasicSearchRequest model)
        {
            var result = _context.Currencies.Where(x => string.IsNullOrEmpty(model.Search) ||
            (x.Name.Contains(model.Search) || x.Code.Contains(model.Search) || x.Description.Contains(model.Search)))
                .Select(x => new CurrencyDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description,
                    Symbol = x.Symbol,
                    DecimalPlaces = x.DecimalPlaces
                }).ToList();

            return result;
        }
    }
}
