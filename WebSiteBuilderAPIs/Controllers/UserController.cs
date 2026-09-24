using Core.Services.IService;
using Core.Services.Service;
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
        private readonly IAddressService AddressService;
        private readonly IUserContactService UserContactService;
        private readonly IUserResidenceService UserResidenceService;
        private readonly IUserRoleService UserRoleService; 
        public UserController(IUnitOfWork unitOfwork, Localizer localizer, IUserService userService, IAddressService addressService,
            IUserContactService usercontactService, IUserResidenceService userResidenceService, IUserRoleService userRoleService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.UserService = userService;
            this.AddressService = addressService;
            this.UserContactService = usercontactService;
            this.UserResidenceService = userResidenceService;
            this.UserRoleService = userRoleService;
        }

        [HttpGet(nameof(GetUsersWithParameters))]
        public IEnumerable<UserDto> GetUsersWithParameters(string fullName)
        {
            return UserService.GetUsersWithParameters(fullName);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add([FromBody]UserViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            if(UnitOfWork.User.DoesEmailAlreadyExist(model.Email))
                return BadRequest(new { success = false, message = string.Format(Localizer.AlreadyExist, Localizer.Email) });

            try
            {
                if (ModelState.IsValid)
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

                    List<UserContact> userContacts = new List<UserContact>();
                    //TODO: implementirati dodavanje vise kontakta i dodati kredencijalni mejl kao dodatni kontakt u UserContactService
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

                    #region UserResidence

                    var address = AddressService.Add(model.UserLocation);

                    model.UserResidence = new UserResidenceViewModel
                    {
                        UserId = user.Id,
                        AddressId = address.Id,
                        IsPrimary = model.UserLocation.IsPrimary
                    };
                    var userResidence = UserResidenceService.Add(model.UserResidence);              
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
