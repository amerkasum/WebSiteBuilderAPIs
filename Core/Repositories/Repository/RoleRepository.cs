using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Role GetByUserId(int userId)
        {
            var roleId = _context.UserRoles.FirstOrDefault(x => x.UserId == userId)?.RoleId;

            var role = _context.Roles.FirstOrDefault(x => x.Id == roleId);

            return role;
        }
    }
}
