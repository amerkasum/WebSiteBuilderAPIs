using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.ViewModels;
using Helpers.Helpers;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IUserService UserService;
        public UserController(IUnitOfWork unitOfwork, Localizer localizer, IUserService userService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.UserService = userService;
        }

        [HttpGet(nameof(GetUsersWithParameters))]
        public IEnumerable<UserDto> GetUsersWithParameters(string fullName)
        {
            return UserService.GetUsersWithParameters(fullName);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add([FromBody]UserViewModel model)
        {
            try
            {
                if (UnitOfWork.User.DoesEmailAlreadyExist(model.Email))
                    return BadRequest(new { success = false, message = string.Format(Localizer.AlreadyExist, Localizer.Email) });

                if (ModelState.IsValid)
                {
                    UnitOfWork.BeginTransaction();
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

                    var userRole = new UserRole
                    {
                        UserId = user.Id,
                        RoleId = model.RoleId
                    };

                    UnitOfWork.UserRole.Add(userRole);
                    UnitOfWork.SaveChanges();

                    List<UserContact> userContacts = new List<UserContact>();
                    
                    model.UserContacts.ForEach(x =>
                    {
                        var userContact = new UserContact
                        {
                            UserId = user.Id,
                            ContactTypeId = x.ContactTypeId,
                            Value = x.Value
                        };
                        userContacts.Add(userContact);
                    });
                    var userContact = new UserContact
                    {
                        UserId = user.Id,
                        ContactTypeId = (int)Enumerations.ContactTypes.EMAIL,
                        Value = user.Email
                    };
                    userContacts.Add(userContact);

                    UnitOfWork.UserContact.AddRange(userContacts);
                    UnitOfWork.SaveChanges();

                    UserResidenceDto userResidence = new UserResidenceDto
                    {
                        Address = model.Address,
                        City = model.City,
                        RegionId = model.RegionId,
                        CountryId = model.CountryId
                    };

                    #region UserResidence

                    var cityExist = UnitOfWork.City.DoesCityExist(model.City, model.PttCode);
                    var city = new City();

                    if (!cityExist)
                    {
                        city = new City
                        {
                            Name = model.City,
                            PttCode = model.PttCode,
                            RegionId = model.RegionId
                        };
                        UnitOfWork.City.Add(city);
                        UnitOfWork.SaveChanges();
                    }
                    else
                    {
                        city = UnitOfWork.City.GetByName(model.City);
                    }

                    var addressExist = UnitOfWork.Address.DoesAddressExist(model.Address);

                    if (!addressExist)
                    {
                        var address = new Address
                        {
                            Name = model.Address,
                            CityId = city.Id
                        };
                        UnitOfWork.Address.Add(address);
                        UnitOfWork.SaveChanges();
                    }
                    #endregion

                    UnitOfWork.Commit();

                    return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.User)});
                }
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).SelectMany(x => x.ErrorMessage).ToList() } );
            }
            catch(Exception e)
            {
                UnitOfWork.RollBack();
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
