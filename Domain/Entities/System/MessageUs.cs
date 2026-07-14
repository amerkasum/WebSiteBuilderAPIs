using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class MessageUs : IEntity
    {
        public int Id { get; set;  }
        public string SenderEmail { get; set; }
        public string Message { get; set; }
        [ForeignKey(nameof(MessageUsReasonId))]
        public MessageUsReason MessageUsReason { get; set; }
        public int MessageUsReasonId { get; set; }
        public DateTime CreatedDateTime { get; set;  }
        public DateTime? ModifiedDateTime { get; set;  }
        public DateTime? DeletedDateTime { get; set;  }
        public bool IsDeleted { get; set;  }
    }
}
