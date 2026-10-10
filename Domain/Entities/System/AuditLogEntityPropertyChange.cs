using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class AuditLogEntityPropertyChange :IEntity
    {
        public int Id { get; set; }
        public string? Property { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public int AuditLogId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
