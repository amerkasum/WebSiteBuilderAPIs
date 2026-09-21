using Domain.Entities.IEntities;
using Domain.Entities.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.System
{
    public class Feedback : IEntity
    {
        public int Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
