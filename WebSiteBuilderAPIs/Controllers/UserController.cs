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
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            if(UnitOfWork.User.DoesEmailAlreadyExist(model.Email))
                return BadRequest(new { success = false, message = string.Format(Localizer.AlreadyExist, Localizer.Email) });

            try
            {
                var user = UserService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.User)});   
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
