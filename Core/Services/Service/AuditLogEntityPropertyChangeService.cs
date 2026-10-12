using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AuditLogEntityPropertyChangeService : IAuditLogEntityPropertyChangeService
    {
        private readonly IUnitOfWork UnitOfWork;
        public AuditLogEntityPropertyChangeService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public async Task<List<AuditLogEntityPropertyChangeDto>> GetAsync(int auditLogId)
        {
            return await UnitOfWork.AuditLogEntityPropertyChange.GetAsync(auditLogId);
        }
    }
}
