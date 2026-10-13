using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Pagination;
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
        private readonly IAuditLogService AuditLogService;
        public ClaimService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.Claim.GetAsync(model);
            return result;
        }

        public async Task<Claim> AddAsync(ClaimViewModel model)
        {
            var claim = new Claim
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.Claim.Add(claim);
            await UnitOfWork.SaveChangesAsync();

            return claim;
        }

        public async Task<Claim> EditAsync(ClaimViewModel model)
        {
            var claim = UnitOfWork.Claim.GetById(model.Id);

            if (claim == null)
                throw new KeyNotFoundException();

            claim.Name = model.Name;
            claim.Code = model.Code;

            UnitOfWork.Claim.Update(claim);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return claim;
        }

        public async Task DeleteAsync(int id)
        {
            var claim = UnitOfWork.Claim.GetById(id);

            if (claim == null)
                throw new KeyNotFoundException();

            UnitOfWork.Claim.Remove(claim);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }

        
    }
}
