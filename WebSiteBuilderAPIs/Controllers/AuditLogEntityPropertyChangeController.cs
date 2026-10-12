using Core.Services.IService;
using Domain.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuditLogEntityPropertyChangeController : ControllerBase
    {
        private readonly IAuditLogEntityPropertyChangeService AuditLogEntityPropertyChangeService;
        public AuditLogEntityPropertyChangeController(IAuditLogEntityPropertyChangeService auditLogEntityPropertyChangeService)
        {
            this.AuditLogEntityPropertyChangeService = auditLogEntityPropertyChangeService;
        }

        [HttpGet(nameof(GetAsync))]
        public async Task<List<AuditLogEntityPropertyChangeDto>> GetAsync(int auditLogId) 
        {
            return await AuditLogEntityPropertyChangeService.GetAsync(auditLogId);
        }
    }
}
