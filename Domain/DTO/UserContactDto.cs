using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserContactDto
    {
        public int Id { get; set; }
        public UserBasicDto User { get; set; }
        public ContactTypeDto ContactType { get; set; }
        public string Value { get; set; }
    }
}
