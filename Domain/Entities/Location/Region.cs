using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Location
{
    public class Region : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
