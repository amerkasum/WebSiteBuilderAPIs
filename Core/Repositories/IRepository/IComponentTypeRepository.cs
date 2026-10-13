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
    public interface IComponentTypeRepository : IRepository<ComponentType>
    {
        Task<PaginationResponse<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
    }
}
