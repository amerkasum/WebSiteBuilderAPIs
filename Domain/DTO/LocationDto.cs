using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public string CityName { get; set; }
        public string PttCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string CountryIso { get; set; }
    }
}
