using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class MessageUsDto
    {
        public int Id { get; set; }
        public string SenderEmail { get; set; }
        public string Message { get; set; }
        public string MessageUsReason { get; set; } 
        public DateTime CreatedDateTime { get; set; }
    }
}
