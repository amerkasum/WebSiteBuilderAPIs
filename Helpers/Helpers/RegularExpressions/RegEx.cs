using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Helpers.RegularExpressions
{
    public static class RegEx
    {
        public const string AllLetters = @"^[\p{L}\s]+$";
        public const string PhoneNumbers = @"^\+?[0-9()\-\s]{7,20}$";
    }
}
