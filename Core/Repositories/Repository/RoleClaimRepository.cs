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
    public class RoleClaimRepository : Repository<RoleClaim>, IRoleClaimRepository
    {
        public RoleClaimRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<RoleClaimDto> Get(RoleClaimRequest model)
        {
            var result = _context.RoleClaim.Include(x => x.Role).Include(x => x.Claim)
                .Where(x => (!model.RoleId.HasValue || model.RoleId == x.Role.Id) && (!model.ClaimId.HasValue || model.ClaimId == x.Claim.Id))
                .Select(x => new RoleClaimDto
                {
                    Id = x.Id,
                    Role = new RoleDto
                    {
                        Id = x.Role.Id,
                        Name = x.Role.Name,
                        Code = x.Role.Code,
                        Description = x.Role.Description
                    },
                    Claim = new ClaimDto
                    {
                        Id = x.Claim.Id,
                        Name = x.Claim.Name,
                        Code = x.Claim.Code,
                        Description = x.Claim.Description
                    }
                }).AsEnumerable();

            return result;
        }
    }
}
