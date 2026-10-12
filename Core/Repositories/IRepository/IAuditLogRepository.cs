using Domain.DTO;
using Domain.Entities.System;
using Domain.Pagination;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAuditLogRepository : IRepository<AuditLog>
    {
        Task<PaginationResponse<AuditLogDto>> Get(AuditLogRequest model);
    }
}
