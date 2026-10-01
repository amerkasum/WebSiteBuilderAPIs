using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class RoleClaimDto
    {
        public int Id { get; set; }
        public RoleDto Role { get; set; }
        public ClaimDto Claim { get; set; }
    }
}
