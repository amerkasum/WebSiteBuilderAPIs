using Domain.Entities.System;
using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class RoleClaimViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int RoleId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int ClaimId { get; set; }
    }
}
