using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class UserContactViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int UserId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int ContactTypeId { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Value { get; set; }
        
    }
}
