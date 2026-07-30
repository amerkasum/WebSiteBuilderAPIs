using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserResidenceDto
    {
        public string Address { get; set; }
        public string City { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
    }
}
