using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Jwt
{
    public class RefreshTokenRequest
    {
        public string RefreshToken { get; set; }
    }
}
