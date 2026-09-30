using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Requests
{
    public class UserSocialMediaRequest
    {
        public string? Search { get; set; }
        public int? SocialMediaId { get; set; }
    }
}
