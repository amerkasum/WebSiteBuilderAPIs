using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class RoleClaimService : IRoleClaimService
    {
        private readonly IUnitOfWork UnitOfWork;
        public RoleClaimService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<RoleClaimDto>> GetAsync(RoleClaimRequest model)
        {
            return await UnitOfWork.RoleClaim.GetAsync(model);
        }

        public async Task<RoleClaim> AddAsync(RoleClaimViewModel model)
        {
            var roleClaim = new RoleClaim
            {
                RoleId = model.RoleId,
                ClaimId = model.ClaimId
            };

            UnitOfWork.RoleClaim.Add(roleClaim);
            await UnitOfWork.SaveChangesAsync();

            return roleClaim;
        }

        public async Task<RoleClaim> EditAsync(RoleClaimViewModel model)
        {
            var roleClaim = UnitOfWork.RoleClaim.GetById(model.Id);

            if (roleClaim == null)
                throw new KeyNotFoundException();

            roleClaim.RoleId = model.RoleId;
            roleClaim.ClaimId = model.ClaimId;

            UnitOfWork.RoleClaim.Update(roleClaim);
            await UnitOfWork.SaveChangesAsync();

            return roleClaim;
        }

        public async Task DeleteAsync(int id)
        {
            var roleClaim = UnitOfWork.RoleClaim.GetById(id);

            if (roleClaim == null)
                throw new KeyNotFoundException();

            UnitOfWork.RoleClaim.Remove(roleClaim);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
