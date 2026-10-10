using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Requests
{
    public class CityRequest
    {
        public string? Search { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

    }
}
