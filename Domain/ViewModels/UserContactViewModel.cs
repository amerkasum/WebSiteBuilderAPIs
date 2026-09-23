using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class UserContactViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContactTypeId { get; set; }
        public string Value { get; set; }
        
    }
}
