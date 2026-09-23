using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class UserResidenceViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int UserId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int AddressId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public bool IsPrimary { get; set; }


    }
}
