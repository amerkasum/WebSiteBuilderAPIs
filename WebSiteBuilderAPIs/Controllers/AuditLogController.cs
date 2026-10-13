using Core.Services.IService;
using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuditLogController : ControllerBase
    {
        private readonly IAuditLogService AuditLogService;
        public AuditLogController(IAuditLogService auditLogService)
        {
            this.AuditLogService = auditLogService;
        }

        [HttpGet(nameof(GetAsync))]
        public async Task<PaginationResponse<AuditLogDto>> GetAsync([FromQuery] AuditLogRequest model)
        {
            return await AuditLogService.GetAsync(model);
        }
    }
}
