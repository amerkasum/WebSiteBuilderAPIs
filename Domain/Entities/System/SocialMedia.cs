using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class SocialMedia : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
