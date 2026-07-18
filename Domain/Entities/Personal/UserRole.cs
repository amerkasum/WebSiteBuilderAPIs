using Domain.Entities.IEntities;
using Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personal
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
