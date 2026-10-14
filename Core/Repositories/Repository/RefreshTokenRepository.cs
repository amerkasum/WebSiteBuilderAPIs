using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(ApplicationDbContext context) : base(context)
        {
        }

        public RefreshToken GetTokenByHash(string tokenHash)
        {
            return _context.RefreshToken.FirstOrDefault(x => x.TokenHash == tokenHash);
        }
    }
}
