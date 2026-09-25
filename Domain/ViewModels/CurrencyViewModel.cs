using Resources.Localizer.Resources.Localizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class CurrencyViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Name { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Code { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public string Symbol { get; set; }
        [Required(ErrorMessage = ValidationMessage.Required)]
        public int DecimalPlaces { get; set; }
    }
}
