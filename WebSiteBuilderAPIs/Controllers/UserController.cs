using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.ViewModels;
using Helpers.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IUserService UserService;
        private readonly IRefreshTokenService RefreshTokenService;
        
        public UserController(IUnitOfWork unitOfwork, Localizer localizer, IUserService userService, IRefreshTokenService refreshTokenService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.UserService = userService;
            this.RefreshTokenService = refreshTokenService;
        }

        [HttpGet(nameof(GetUsersWithParameters))]
        public IEnumerable<UserDto> GetUsersWithParameters(string fullName)
        {
            return UserService.GetUsersWithParameters(fullName);
        }

        [AllowAnonymous]
        [HttpPost(nameof(RefreshToken))]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            var result = await RefreshTokenService.RefreshTokenAsync(refreshToken);

            return Ok(new { success = true, data = result });
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add([FromBody]UserViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            if(UnitOfWork.User.DoesEmailAlreadyExist(model.Email))
                return BadRequest(new { success = false, message = string.Format(Localizer.AlreadyExist, Localizer.Email) });

            try
            {
                var user = await UserService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.User)});   
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [AllowAnonymous]
        [HttpPost(nameof(LogIn))]
        public IActionResult LogIn(LogInViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var response = UserService.LogInAsync(model);

                return Ok(new { success = true, message = Localizer.SuccessfulLogIn, data = response });
            }
            catch (UnauthorizedAccessException)
            {
                return BadRequest(new { success = false, message = Localizer.Unauthorized });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.User) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPost(nameof(LogOut))]
        [AllowAnonymous]
        public async Task<IActionResult> LogOut([FromBody] string refreshToken)
        {
            try
            {
                await UserService.LogOutAsync(refreshToken);
                return Ok(new { success = true, message = Localizer.LoggedOutSuccessfully });
            }
            catch(UnauthorizedAccessException)
            {
                return BadRequest(new { success = false, message = Localizer.LogOutFailed });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
