using Domain.Entities.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IRefreshTokenRepository : IRepository<RefreshToken>
    {
        RefreshToken GetTokenByHash(string tokenHash);
    }
}
