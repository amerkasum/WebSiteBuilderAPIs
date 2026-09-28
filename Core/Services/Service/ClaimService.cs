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
    public class ClaimService : IClaimService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ClaimService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = UnitOfWork.Claim.Get(model);
            return result;
        }

        public Claim Add(ClaimViewModel model)
        {
            var claim = new Claim
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.Claim.Add(claim);
            UnitOfWork.SaveChanges();

            return claim;
        }

        public Claim Edit(ClaimViewModel model)
        {
            var claim = UnitOfWork.Claim.GetById(model.Id);

            if (claim == null)
                throw new KeyNotFoundException();

            claim.Name = model.Name;
            claim.Code = model.Code;

            UnitOfWork.Claim.Update(claim);
            UnitOfWork.SaveChanges();

            return claim;
        }

        public void Delete(int id)
        {
            var claim = UnitOfWork.Claim.GetById(id);

            if (claim == null)
                throw new KeyNotFoundException();

            UnitOfWork.Claim.Remove(claim);
            UnitOfWork.SaveChanges();
        }

        
    }
}
