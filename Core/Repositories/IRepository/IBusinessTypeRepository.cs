using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
using Domain.Pagination;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IBusinessTypeRepository : IRepository<BusinessType>
    {
        Task<PaginationResponse<BasicSearchResponse>> Get(BasicSearchRequest model);
    }
}
