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
    public class UserResidenceRepository : Repository<UserResidence>, IUserResidenceRepository
    {
        public UserResidenceRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
