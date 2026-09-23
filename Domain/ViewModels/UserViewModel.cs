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
    public class UserViewModel
    {
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string LastName { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        [EmailAddress]
        public  string Email { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int GenderId { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int RoleId { get; set; }
        public LocationViewModel UserLocation { get; set; }
        public UserResidenceViewModel UserResidence { get; set; }
        public string? ImageUrl { get; set; }
        public List<UserContactViewModel> UserContacts { get; set; }
    }
}
