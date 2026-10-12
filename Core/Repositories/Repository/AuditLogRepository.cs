using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Entities.System;
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
    public class AuditLogRepository : Repository<AuditLog>, IAuditLogRepository
    {
        public AuditLogRepository(LogsDbContext logsContext) : base(logsContext)
        {
        }

        public async Task<PaginationResponse<AuditLogDto>> Get(AuditLogRequest model)
        {
            var query = _logsContext.AuditLog.AsNoTracking().Where(x =>
            (!model.UserId.HasValue || model.UserId == x.UserId) &&
            (!model.DateFrom.HasValue || (x.CreatedDateTime > model.DateFrom)) &&
            (!model.DateTo.HasValue || (x.CreatedDateTime < model.DateTo)));

            var totalCount = query.Count();

            var result = await query.Select(x => new AuditLogDto
            {
                Id = x.Id,
                BrowserInfo = x.BrowserInfo,
                Controller = x.Controller,
                EntityId = x.EntityId,
                Method = x.Method,
                CreatedDateTime = x.CreatedDateTime,
                Table = x.Table,
                Url = x.Url,
                QueryParameters = x.QueryParameters,
                User = new UserBasicDto
                {
                    Id = x.UserId
                }
            }).OrderByDescending(x => x.CreatedDateTime).Skip(model.PageSize * (model.PageNumber - 1)).Take(model.PageSize).ToListAsync();

            return new PaginationResponse<AuditLogDto> { Data = result, TotalCount = totalCount, PageNumber = model.PageNumber, PageSize = model.PageSize,
               TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize)};
        }
    }
}
