using Domain.Entities.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Location
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PttCode { get; set; }
        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }
        public int RegionId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
