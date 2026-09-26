using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Jwt
{
    public class LogInResponseDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
