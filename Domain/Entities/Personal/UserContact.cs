using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Helpers.RegularExpressions;

namespace Domain.Entities.Personal
{
    public class UserContact : IEntity
    {
        public int Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [RegularExpression(RegEx.PhoneNumbers)]
        public string PhoneNumber { get; set; }
        public DateTime CreatedDateTime {get; set; }
        public DateTime? ModifiedDateTime {get; set; }
        public DateTime? DeletedDateTime {get; set; }
        public bool IsDeleted {get; set; }
    }
}
