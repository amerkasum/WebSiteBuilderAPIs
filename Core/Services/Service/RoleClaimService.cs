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

        public IEnumerable<RoleClaimDto> Get(RoleClaimRequest model)
        {
            return UnitOfWork.RoleClaim.Get(model);
        }

        public RoleClaim Add(RoleClaimViewModel model)
        {
            var roleClaim = new RoleClaim
            {
                RoleId = model.RoleId,
                ClaimId = model.ClaimId
            };

            UnitOfWork.RoleClaim.Add(roleClaim);
            UnitOfWork.SaveChanges();

            return roleClaim;
        }

        public RoleClaim Edit(RoleClaimViewModel model)
        {
            var roleClaim = UnitOfWork.RoleClaim.GetById(model.Id);

            if (roleClaim == null)
                throw new KeyNotFoundException();

            roleClaim.RoleId = model.RoleId;
            roleClaim.ClaimId = model.ClaimId;

            UnitOfWork.RoleClaim.Update(roleClaim);
            UnitOfWork.SaveChanges();

            return roleClaim;
        }

        public void Delete(int id)
        {
            var roleClaim = UnitOfWork.RoleClaim.GetById(id);

            if (roleClaim == null)
                throw new KeyNotFoundException();

            UnitOfWork.RoleClaim.Remove(roleClaim);
            UnitOfWork.SaveChanges();
        }
    }
}
