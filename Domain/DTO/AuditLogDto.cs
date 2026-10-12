using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class AuditLogDto
    {
        public int Id { get; set; }
        public UserBasicDto User { get; set; }
        public int EntityId { get; set; }
        public string? Table { get; set; }
        public string? Url { get; set; }
        public string? Controller { get; set; }
        public string? Method { get; set; }
        public string? BrowserInfo { get; set; }
        public string? QueryParameters { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
