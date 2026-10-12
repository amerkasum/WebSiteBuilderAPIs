using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class AuditLogEntityPropertyChangeDto
    {
        public int Id { get; set; }
        public string? Property { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
