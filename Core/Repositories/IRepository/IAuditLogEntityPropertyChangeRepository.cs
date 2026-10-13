using Domain.DTO;
using Domain.Entities.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAuditLogEntityPropertyChangeRepository : IRepository<AuditLogEntityPropertyChange>
    {
        Task<List<AuditLogEntityPropertyChangeDto>> GetAsync(int auditLogId);
    }
}
