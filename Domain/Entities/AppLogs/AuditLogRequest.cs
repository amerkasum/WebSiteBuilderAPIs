using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Logs
{
    public class AuditLogRequest
    {
        public int? UserId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

    }
}
