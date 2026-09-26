using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = ValidationMessage.Required)]
        [EmailAddress(ErrorMessage = ValidationMessage.InvalidEmail)]
        public string Email { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Password { get; set; }
    }
}
