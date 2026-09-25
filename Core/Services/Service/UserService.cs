using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.ViewModels;
using Helpers.Helpers;
using Microsoft.IdentityModel.Tokens;
using Resources.Localizer;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public UserService(IUnitOfWork unitOfWork, Localizer localizer, IAddressService addressService,
            IUserContactService usercontactService, IUserResidenceService userResidenceService, IUserRoleService userRoleService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.AddressService = addressService;
            this.UserContactService = usercontactService;
            this.UserResidenceService = userResidenceService;
            this.UserRoleService = userRoleService;
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
                //TODO UserService
                var user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Username = model.FirstName.ToLower() + "." + model.LastName.ToLower(),
                    Email = model.Email,
                    Password = PasswordHelper.GenerateHash(model.Password, PasswordHelper.GenerateRandomSalt()),
                    GenderId = model.GenderId,
                    BirthDate = model.BirthDate,
                    ImageUrl = model.ImageUrl
                };

                UnitOfWork.User.Add(user);
                UnitOfWork.SaveChanges();

                //TODO: UserRoleService
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

                model.UserResidence = new UserResidenceViewModel
                {
                    UserId = user.Id,
                    AddressId = address.Id,
                    IsPrimary = model.UserLocation.IsPrimary
                };
                var userResidence = UserResidenceService.Add(model.UserResidence);
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
    }
}
