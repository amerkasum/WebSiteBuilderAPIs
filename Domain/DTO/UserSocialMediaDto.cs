using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserSocialMediaDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaIcon { get; set; }
        public string SocialMediaColor { get; set; }
        public int SocialMediaDisplayOrder { get; set; }
        public string Link { get; set; }
    }
}
