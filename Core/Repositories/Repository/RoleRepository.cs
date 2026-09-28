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
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model)
        {
            var result = _context.Roles.Where(x => string.IsNullOrEmpty(model.Search) ||
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

        public Role GetByUserId(int userId)
        {
            var roleId = _context.UserRoles.FirstOrDefault(x => x.UserId == userId)?.RoleId;

            var role = _context.Roles.FirstOrDefault(x => x.Id == roleId);

            return role;
        }
    }
}
