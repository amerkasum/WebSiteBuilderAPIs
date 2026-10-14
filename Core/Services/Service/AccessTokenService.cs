using Core.Services.IService;
using Domain.Entities.Jwt;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AccessTokenService : IAccessTokenService
    {
        private readonly IConfiguration Configuration;
        public AccessTokenService(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public TokenResponse GenerateToken(User user, Role role)
        {
            var jwtSettings = Configuration
                .GetSection("Jwt")
                .Get<JwtSettings>();

            var expiresAt = DateTime.UtcNow.AddMinutes(jwtSettings.ExpiresInMinutes);

            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new System.Security.Claims.Claim(ClaimTypes.Email, user.Email),
                new System.Security.Claims.Claim(ClaimTypes.Role, role.Name),
                new System.Security.Claims.Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtSettings.Key));

            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims.AsEnumerable(),
                expires: DateTime.UtcNow.AddMinutes(
                    jwtSettings.ExpiresInMinutes),
                signingCredentials: credentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var tokenResponse = new TokenResponse
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ExpiresAt = DateTime.UtcNow.AddMinutes(jwtSettings.ExpiresInMinutes)
            };

            return tokenResponse;
        }
    }
}
