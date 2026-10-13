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
    public class SocialMediaRepository : Repository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(ApplicationDbContext context) : base(context)
        {    
        }

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            var result = _context.SocialMedia.Where(x => string.IsNullOrEmpty(model.Search) ||
            (x.Name.Contains(model.Search) || x.Code.Contains(model.Search) || x.Description.Contains(model.Search)))
                .Select(x => new BasicSearchResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description
                }).ToList();

            return result;
        }

        public int GetHighestDisplayOrder()
        {
            return _context.SocialMedia.Max(x => x.DisplayOrder);
        }
    }
}
