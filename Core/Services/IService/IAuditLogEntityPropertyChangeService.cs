using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAuditLogEntityPropertyChangeService
    {
        Task<List<AuditLogEntityPropertyChangeDto>> GetAsync(int auditLogId);
    }
}
