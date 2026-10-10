using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class CityViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Name { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string PttCode { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int RegionId { get; set; }
    }
}
