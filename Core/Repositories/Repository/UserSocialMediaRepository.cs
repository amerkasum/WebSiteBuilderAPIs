using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.Personal;
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

        public List<UserSocialMedia> GetByUserId(int userId)
        {
            var userSocialMedia = _context.UserSocialMedia.Include(x => x.User).Include(x => x.SocialMedia).Where(x => x.UserId == userId).ToList();

            return userSocialMedia;
        }
    }
}
