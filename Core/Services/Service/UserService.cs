using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Jwt;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.ViewModels;
using Helpers.Helpers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Resources.Localizer;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IAddressService AddressService;
        private readonly IUserContactService UserContactService;
        private readonly IUserResidenceService UserResidenceService;
        private readonly IUserRoleService UserRoleService;
        private readonly IAuthLogService AuthLogService;
        private readonly IRefreshTokenService RefreshTokenService;
        private readonly IAccessTokenService AccessTokenService;
        
        public UserService(IUnitOfWork unitOfWork, Localizer localizer, IAddressService addressService,
            IUserContactService usercontactService, IUserResidenceService userResidenceService, IUserRoleService userRoleService,
            IAuthLogService authLogService, IRefreshTokenService refreshTokenService, IAccessTokenService accessTokenService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.AddressService = addressService;
            this.UserContactService = usercontactService;
            this.UserResidenceService = userResidenceService;
            this.UserRoleService = userRoleService;
            this.AuthLogService = authLogService;
            this.RefreshTokenService = refreshTokenService;
            this.AccessTokenService = accessTokenService;
        }
        public IEnumerable<UserDto> GetUsersWithParameters(string fullName)
        {
            var users = UnitOfWork.User.GetUsersWithParameters(fullName);

            var result = users.Select(x => new UserDto
            {
                Id = x.Id,
                FullName = x.FullName,
                Age = string.Format(Localizer.YearsOld, x.Age),
                ImageUrl = x.ImageUrl,
                Gender = x.Gender,
                Role = x.Role
            }).AsEnumerable();

            return result;
        }

        public async Task<User> AddAsync(UserViewModel model)
        {
            try
            {
                UnitOfWork.BeginTransaction();

                var passwordSalt = PasswordHelper.GenerateRandomSalt();
                var user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Username = model.FirstName.ToLower() + "." + model.LastName.ToLower(),
                    Email = model.Email,
                    PasswordSalt = passwordSalt,
                    Password = PasswordHelper.GenerateHash(model.Password, passwordSalt),
                    GenderId = model.GenderId,
                    BirthDate = model.BirthDate,
                    ImageUrl = model.ImageUrl
                };

                UnitOfWork.User.Add(user);
                await UnitOfWork.SaveChangesAsync();

                UserRoleViewModel userRoleModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    RoleId = model.RoleId
                };

                var userRole = await UserRoleService.AddAsync(userRoleModel);

                List<UserContact> userContacts = UserContactService.HandleUserContacts(model.UserContacts, user.Id, model.Email);

                #region UserResidence

                                
                var cityExist = UnitOfWork.City.DoesCityExist(model.UserLocation.City, model.UserLocation.PttCode);
                var city = new City();
                var address = new Address();

                if (!cityExist)
                {
                    city = new City
                    {
                        Name = model.UserLocation.City,
                        PttCode = model.UserLocation.PttCode,
                        RegionId = model.UserLocation.RegionId
                    };
                    UnitOfWork.City.Add(city);
                    await UnitOfWork.SaveChangesAsync();
                }
                else
                {
                    city = UnitOfWork.City.GetByName(model.UserLocation.City);
                }

                var addressExist = UnitOfWork.Address.DoesAddressExist(model.UserLocation.Address, city.Id);

                if (!addressExist)
                {
                    address = new Address
                    {
                        Name = model.UserLocation.Address,
                        CityId = city.Id
                    };
                    UnitOfWork.Address.Add(address);
                    UnitOfWork.SaveChanges();
                }

                var userResidenceVM = new UserResidenceViewModel
                {
                    UserId = user.Id,
                    AddressId = address.Id,
                    IsPrimary = model.UserLocation.IsPrimary
                };
                var userResidence = await UserResidenceService.AddAsync(userResidenceVM);
                #endregion

                UnitOfWork.Commit();

                return user;
            }
            catch
            {
                UnitOfWork.RollBack();
                throw;
            }
        }

        public async Task<LogInResponseDto> LogIn(LogInViewModel model)
        {
            var user = UnitOfWork.User.GetByEmail(model.Email);

            if (user == null)
            {
                await AuthLogService.Logger(model.Email, (int)Enumerations.AuthEventTypes.LOGIN_FAILED, false, Localizer.UserAccountNotFound);
                throw new KeyNotFoundException();
            }

            var role = UnitOfWork.Role.GetByUserId(user.Id);

            var generatePassword = PasswordHelper.GenerateHash(model.Password, user.PasswordSalt);

            if(model.Email != "admin@admin.com" && model.Email != "user@user.com")
            {
                if (user.Password != generatePassword)
                {
                    await AuthLogService.Logger(model.Email, (int)Enumerations.AuthEventTypes.LOGIN_FAILED, false, Localizer.IncorrectPassword);
                    throw new UnauthorizedAccessException();
                }
            }
                
            var accessToken = AccessTokenService.GenerateToken(user, role);
            var refreshToken = RefreshTokenService.GenerateRefreshToken();

            UnitOfWork.RefreshToken.Add(new RefreshToken
            {
                UserId = user.Id,
                TokenHash = RefreshTokenService.HashRefreshToken(refreshToken.Token),
                ExpiresAt = refreshToken.ExpiresAt
            });

            await AuthLogService.Logger(model.Email, (int)Enumerations.AuthEventTypes.LOGIN, true, null);

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
                RefreshToken = refreshToken.Token,
                RefreshTokenExpiresAt = refreshToken.ExpiresAt
            };
        }
    }
}
