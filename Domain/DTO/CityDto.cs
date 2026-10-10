using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PttCode { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string RegionCountry { get; set; }
    }
}
