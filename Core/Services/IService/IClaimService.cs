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

namespace Core.Services.IService
{
    public interface IClaimService
    {
        Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<Claim> AddAsync(ClaimViewModel model);
        Task<Claim> EditAsync(ClaimViewModel model);
        Task DeleteAsync(int id);
    }
}
