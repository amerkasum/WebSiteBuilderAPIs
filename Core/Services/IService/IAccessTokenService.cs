using Domain.Entities.Jwt;
using Domain.Entities.Personal;
using Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAccessTokenService
    {
        TokenResponse GenerateToken(User user, Role role);
    }
}
