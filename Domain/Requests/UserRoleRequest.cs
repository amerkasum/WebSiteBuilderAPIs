using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Requests
{
    public class UserRoleRequest
    {
        public string? Search { get; set; }
        public int? RoleId { get; set; }
        public int? ClaimId { get; set; }
    }
}
