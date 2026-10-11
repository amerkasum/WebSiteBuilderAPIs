using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Location
{
    public class Country : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime {get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? CreatedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
