using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Helpers
{
    public static class DateTimeHelper
    {
        public static int GetAge(DateTime? birthDate)
        {
            int? age = null;
            if(birthDate != null)
            {
                var today = DateTime.Today;
                age = today.Year - birthDate?.Year;
                if (birthDate?.Date > today.AddYears(-age.Value)) age--;
            }
            
            return age.Value;
        }
    }
}
