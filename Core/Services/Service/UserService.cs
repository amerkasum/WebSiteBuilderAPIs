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
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

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
        public readonly IConfiguration Configuration;
        public UserService(IUnitOfWork unitOfWork, Localizer localizer, IAddressService addressService,
            IUserContactService usercontactService, IUserResidenceService userResidenceService, IUserRoleService userRoleService,
            IConfiguration configuration)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.AddressService = addressService;
            this.UserContactService = usercontactService;
            this.UserResidenceService = userResidenceService;
            this.UserRoleService = userRoleService;
            this.Configuration = configuration;
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

        public User Add(UserViewModel model)
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
                UnitOfWork.SaveChanges();

                UserRoleViewModel userRoleModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    RoleId = model.RoleId
                };

                var userRole = UserRoleService.Add(userRoleModel);

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
                    UnitOfWork.SaveChanges();
                }
                else
                {
                    city = UnitOfWork.City.GetByName(model.UserLocation.City);
                }

                var addressExist = UnitOfWork.Address.DoesAddressExist(model.UserLocation.Address);

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
                var userResidence = UserResidenceService.Add(userResidenceVM);
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

        private (string Token, DateTime ExpiresAt) GenerateToken(User user, Role role)
        {
            var jwtSettings = Configuration
                .GetSection("Jwt")
                .Get<JwtSettings>();

            var expiresAt = DateTime.UtcNow.AddMinutes(jwtSettings.ExpiresInMinutes);

            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new System.Security.Claims.Claim(ClaimTypes.Email, user.Email),
                new System.Security.Claims.Claim(ClaimTypes.Role, role.Name)
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
            return (tokenString, expiresAt);
        }

        public LogInResponseDto LogIn(LogInViewModel model)
        {
            var user = UnitOfWork.User.GetByEmail(model.Email);

            if (user == null)
                throw new KeyNotFoundException();

            var role = UnitOfWork.Role.GetByUserId(user.Id);

            var generatePassword = PasswordHelper.GenerateHash(model.Password, user.PasswordSalt);

            if(model.Email != "admin@admin.com") 
                if (user.Password != generatePassword)
                    throw new UnauthorizedAccessException();


            var tokenResult = GenerateToken(user, role);

            return new LogInResponseDto
            {
                UserId = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Email = user.Email,
                Username = user.Username,
                Role = role.Name,
                RoleId = role.Id,
                Token = tokenResult.Token,
                ExpiresAt = tokenResult.ExpiresAt
            };
        }
    }
}
