using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
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
    public class BusinessTypeRepository : Repository<BusinessType>, IBusinessTypeRepository
    {
        public BusinessTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PaginationResponse<BasicSearchResponse>> Get(BasicSearchRequest model)
        {
            var query = _context.BusinessTypes.AsNoTracking().Where(x => string.IsNullOrEmpty(model.Search) ||
            (x.Name.Contains(model.Search) || x.Code.Contains(model.Search) || x.Description.Contains(model.Search)));

            var totalCount = query.Count();

            var result = await query.Select(x => new BasicSearchResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description
                }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber -1)).Take(model.PageSize).ToListAsync();

            return new PaginationResponse<BasicSearchResponse> { Data = result, PageNumber = model.PageNumber, PageSize = model.PageSize, TotalCount = totalCount,
                                                                 TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize)};
        }
    }
}
