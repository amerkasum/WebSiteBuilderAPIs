using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
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

        public List<SocialMediaDto> GetAll()
        {
            return _context.SocialMedia.Where(x => !x.IsDeleted).Select(x => new SocialMediaDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Icon = x.Icon,
                Color = x.Color,
                DisplaOrder = x.DisplayOrder
            }).OrderBy(x => x.DisplaOrder).ToList();
        }

        //returns id, name.toLower(), color
        public IEnumerable<SocialMediaBasicDto> GetSocialMediaBasic()
        {
            return _context.SocialMedia.Where(x => !x.IsDeleted).Select(x => new SocialMediaBasicDto
            {
                Id = x.Id,
                Name = x.Name.ToLower(),
                Color = x.Color,
                Code = x.Code.ToLower(),
                Icon = x.Icon
            });
        }
    }
}
