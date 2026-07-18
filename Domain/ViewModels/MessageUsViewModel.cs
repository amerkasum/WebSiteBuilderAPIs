using Resources.Localizer;
using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class MessageUsViewModel
    {
        [EmailAddress(ErrorMessage = ValidationMessage.InvalidEmail)]
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string EmailSender { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Message { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int MessageUsReasonId { get; set; }

    }
}
