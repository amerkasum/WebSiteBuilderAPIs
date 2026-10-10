using Domain.Entities.IEntities;
using Domain.Entities.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public record AuditLog :IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? HttpMethod { get; set; }
        public string? Method { get; set; }
        public string? Controller { get; set; }
        public string? BrowserInfo { get; set; }
        public string? Table { get; set; }
        public string? Url { get; set; }
        public string? EntityId { get; set; }
        public string? QueryParameters { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
