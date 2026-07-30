using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class UserActivityRepository : Repository<UserActivity>, IUserActivityRepository
    {
        public UserActivityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
