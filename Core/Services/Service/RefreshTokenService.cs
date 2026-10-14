using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.Jwt;
using Helpers.Helpers;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Resources.Localizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IAccessTokenService AccessTokenService;
        private readonly IAuthLogService AuthLogService;
        public RefreshTokenService(IUnitOfWork unitOfWork, IAccessTokenService accessTokenService, IAuthLogService authLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AccessTokenService = accessTokenService;
            this.AuthLogService = authLogService;
        }
        public TokenResponse GenerateRefreshToken()
        {
            var token = new TokenResponse
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                ExpiresAt = DateTime.UtcNow.AddDays(7)
            };

            return token;
        }

        public string HashRefreshToken(string token)
        {
            return Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(token)));
        }

        public async Task<LogInResponseDto> RefreshTokenAsync(string refreshToken)
        {
            if(string.IsNullOrEmpty(refreshToken))
            {
                await AuthLogService.Logger("Unknown", (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_FAILED, false, "Refresh token was not provided.");
                throw new UnauthorizedAccessException();
            }


            var tokenHash = HashRefreshToken(refreshToken);

            var storedToken = UnitOfWork.RefreshToken.GetTokenByHash(tokenHash);

            if (storedToken == null)
            {
                await AuthLogService.Logger("Unknown", (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_FAILED, false, "Refresh token was not found.");
                throw new UnauthorizedAccessException();
            }
                

            var user = UnitOfWork.User.GetById(storedToken.UserId);

            if (user == null)
            {
                await AuthLogService.Logger("Unknown", (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_FAILED, false, "User associated with refresh token was not found.");
                throw new UnauthorizedAccessException();
            }

            if (storedToken.RevokedAt.HasValue)
            {
                await AuthLogService.Logger(user.Email, (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_FAILED, false, "Refresh token has already been revoked.");

                throw new UnauthorizedAccessException();
            }

            if (storedToken.ExpiresAt <= DateTime.UtcNow)
            {
                await AuthLogService.Logger(user.Email, (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_FAILED, false, "Refresh token has expired.");

                throw new UnauthorizedAccessException();
            }


            var role = UnitOfWork.Role.GetByUserId(user.Id);


            storedToken.RevokedAt = DateTime.UtcNow;

            var newRefreshToken = GenerateRefreshToken();

            UnitOfWork.RefreshToken.Add(new RefreshToken
            {
                UserId = user.Id,
                TokenHash = HashRefreshToken(newRefreshToken.Token),
                ExpiresAt = newRefreshToken.ExpiresAt
            });

            var accessToken = AccessTokenService.GenerateToken(user, role);
            await UnitOfWork.SaveChangesAsync();

            await AuthLogService.Logger(user.Email, (int)Enumerations.AuthEventTypes.REFRESH_TOKEN_SUCCESS, true, null);

            return new LogInResponseDto
            {
                UserId = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Email = user.Email,
                Username = user.Username,
                Role = role.Name,
                RoleId = role.Id,
                AccessToken = accessToken.Token,
                AccessTokenExpiresAt = accessToken.ExpiresAt,
                RefreshToken = newRefreshToken.Token,
                RefreshTokenExpiresAt = newRefreshToken.ExpiresAt
            };
        }
    }
}
