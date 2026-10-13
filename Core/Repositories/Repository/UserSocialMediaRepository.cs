using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class UserSocialMediaRepository : Repository<UserSocialMedia>, IUserSocialMediaRepository
    {
        public UserSocialMediaRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UserSocialMediaDto>> GetAsync(UserSocialMediaRequest model)
        {
            var query = _context.UserSocialMedia.AsNoTracking()
                .Where(x => !x.IsDeleted &&
                (string.IsNullOrEmpty(model.Search) || (x.User.FirstName.Contains(model.Search) && x.User.LastName.Contains(model.Search) && x.User.Username.Contains(model.Search))) &&
                (!model.SocialMediaId.HasValue || model.SocialMediaId == x.SocialMedia.Id));

            var result = await query.Select(x => new UserSocialMediaDto
                {
                    Id = x.Id,
                    User = new UserBasicDto
                    {
                        Id = x.User.Id,
                        FullName = $"{x.User.FirstName} {x.User.LastName}",
                        Email = x.User.Email,
                        Username = x.User.Username
                    },
                    SocialMedia = new SocialMediaDto
                    {
                        Id = x.Id, 
                        Name = x.SocialMedia.Name,
                        Code = x.SocialMedia.Code,
                        Icon = x.SocialMedia.Icon,
                        Color = x.SocialMedia.Color,
                        DisplaOrder = x.SocialMedia.DisplayOrder
                    },
                    Link = x.Link
                }).ToListAsync();

            return result;
        }
    }
}
