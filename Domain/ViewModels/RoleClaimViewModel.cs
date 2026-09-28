using Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class RoleClaimViewModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ClaimId { get; set; }
    }
}
