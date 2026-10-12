using Domain.DTO;
using Domain.Pagination;
using Domain.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAuditLogService
    {
        Task Logger();
        Task<PaginationResponse<AuditLogDto>> GetAsync(AuditLogRequest model);
    }
}
