using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class LocationViewModel
    {
        public string AddressName { get; set; }
        public string CityName { get; set; }
        public string PttCode { get; set; }
        public int RegionId { get; set; }
    }
}
