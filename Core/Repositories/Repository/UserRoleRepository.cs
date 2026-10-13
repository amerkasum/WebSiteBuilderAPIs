using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Pagination;
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

        public async Task<PaginationResponse<UserRoleDto>> GetAsync(UserRoleRequest model)
        {
            var roleClaims = _context.RoleClaim.Include(x => x.Claim)
                .Where(x => (!model.RoleId.HasValue || (x.RoleId == model.RoleId)) &&
                (!model.ClaimId.HasValue || (x.ClaimId == model.ClaimId)));

            var query = _context.UserRoles.AsNoTracking()
                .Where(ur => (string.IsNullOrEmpty(model.Search) || ur.User.FirstName.Contains(model.Search) ||
                             ur.User.LastName.Contains(model.Search) || ur.User.Email.Contains(model.Search))
                    && (!model.RoleId.HasValue || ur.RoleId == model.RoleId));

            var totalCount = await query.CountAsync();

            var result = await query.Select(ur => new UserRoleDto
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
            }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber - 1)).Take(model.PageSize).ToListAsync();

            return new PaginationResponse<UserRoleDto> { Data = result, PageNumber = model.PageNumber, PageSize = model.PageSize, TotalCount = totalCount, 
                                                         TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize) };
        }
    }
}
