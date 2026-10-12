using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class AuditLogEntityPropertyChangeRepository : Repository<AuditLogEntityPropertyChange>, IAuditLogEntityPropertyChangeRepository
    {
        public AuditLogEntityPropertyChangeRepository(LogsDbContext logsContext) : base(logsContext)
        {
        }

        public async Task<List<AuditLogEntityPropertyChangeDto>> GetAsync(int auditLogId)
        {
            var result = await _logsContext.AuditLogEntityPropertyChange.Where(x => auditLogId == x.AuditLogId).Select(x => new AuditLogEntityPropertyChangeDto
            {
                Id = x.Id,
                Property = x.Property,
                OldValue= x.OldValue,
                NewValue = x.NewValue
            }).ToListAsync();

            return result;
        }
    }
}
