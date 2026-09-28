using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class RoleClaim : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        public int RoleId { get; set; }
        [ForeignKey(nameof(ClaimId))]
        public Claim Claim { get; set; }
        public int ClaimId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
