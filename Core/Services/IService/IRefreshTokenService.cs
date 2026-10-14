using Domain.Entities.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IRefreshTokenService
    {
        TokenResponse GenerateRefreshToken();
        string HashRefreshToken(string token);
        Task<LogInResponseDto> RefreshTokenAsync(string refreshToken);
    }
}
