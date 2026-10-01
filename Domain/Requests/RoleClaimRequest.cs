using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Requests
{
    public class RoleClaimRequest
    {
        public int? RoleId { get; set; }
        public int? ClaimId { get; set; }
    }
}
