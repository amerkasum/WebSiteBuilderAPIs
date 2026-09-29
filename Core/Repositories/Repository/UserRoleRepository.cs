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
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<UserRoleDto> Get(UserRoleRequest model)
        {
            var roleClaims = _context.RoleClaim.Include(x => x.Claim)
                .Where(x => (!model.RoleId.HasValue || (x.RoleId == model.RoleId)) &&
                (!model.ClaimId.HasValue || (x.ClaimId == model.ClaimId))).ToList();

            var result = _context.UserRoles.Include(x => x.User).Include(x => x.Role)
                .Where(ur => (string.IsNullOrEmpty(model.Search) || ur.User.FirstName.Contains(model.Search) ||
                             ur.User.LastName.Contains(model.Search) || ur.User.Email.Contains(model.Search))
                    && (!model.RoleId.HasValue || ur.RoleId == model.RoleId)).ToList()
                .Select(ur => new UserRoleDto
                {
                    Id = ur.Id,
                    UserId = ur.UserId,
                    RoleId = ur.RoleId,
                    FullName = $"{ur.User.FirstName} {ur.User.LastName}",
                    Email = ur.User.Email,
                    RoleName = ur.Role.Name,
                    Claims = roleClaims.Where(rc => rc.RoleId == ur.RoleId).Select(rc => new ClaimDto //
                    {
                        Id = rc.Claim.Id,
                        Name = rc.Claim.Name,
                        Description = rc.Claim.Description,
                        Code = rc.Claim.Code
                    }).ToList()
                });

            return result;
        }
    }
}
