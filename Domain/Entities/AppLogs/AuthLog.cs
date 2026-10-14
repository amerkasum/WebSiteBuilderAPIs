using Domain.Entities.IEntities;
using Domain.Entities.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.AppLogs
{
    public class AuthLog : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(AuthEventTypeId))]
        public AuthEventType AuthEventType { get; set; }
        public int AuthEventTypeId { get; set; }
        public string Email { get; set; }
        public bool IsSuccessful { get; set; }
        public string? IpAddress { get; set; }
        public string? BrowserInfo { get; set; }
        public string? FailureReason { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? CreatedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
