using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class FeedbackViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int UserId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Message { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
