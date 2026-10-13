using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class ContactTypeRepository : Repository<ContactType>, IContactTypeRepository
    {
        public ContactTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            var result = await _context.ContactTypes.AsNoTracking().Where(x => string.IsNullOrEmpty(model.Search) ||
            (x.Name.Contains(model.Search) || x.Code.Contains(model.Search) || x.Description.Contains(model.Search)))
                .Select(x => new BasicSearchResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description
                }).ToListAsync();

            return result;
        }
    }
}
