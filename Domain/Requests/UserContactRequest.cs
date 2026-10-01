using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Requests
{
    public class UserContactRequest
    {
        public string? Sreach { get; set; }
        public int? UserId { get; set; }
        public int? ContactTypeId { get; set; }
        
    }
}
