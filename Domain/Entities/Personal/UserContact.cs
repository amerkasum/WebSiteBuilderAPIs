using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Helpers.RegularExpressions;
using Domain.Entities.System;

namespace Domain.Entities.Personal
{
    public class UserContact : IEntity
    {
        public int Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(ContactTypeId))]
        public ContactType ContactType { get; set; }
        public int ContactTypeId { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDateTime {get; set; }
        public DateTime? ModifiedDateTime {get; set; }
        public DateTime? DeletedDateTime {get; set; }
        public bool IsDeleted {get; set; }
    }
}
