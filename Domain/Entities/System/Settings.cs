using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class Settings : IEntity
    {
        [Key]
        public int Id { get ;set;  }
        public bool DarkMode { get; set; }
        public bool StickyNavBar { get; set; }
        public DateTime CreatedDateTime { get ;set;  }
        public DateTime? ModifiedDateTime { get ;set;  }
        public DateTime? DeletedDateTime { get ;set;  }
        public int? CreatedById { get; set; }
        public bool IsDeleted { get; set;  }
    }
}
