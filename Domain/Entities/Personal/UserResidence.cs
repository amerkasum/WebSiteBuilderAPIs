using Domain.Entities.IEntities;
using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personal
{
    public class UserResidence : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
