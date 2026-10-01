using Core.Services.IService;
using Domain.DTO;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService UserRoleService;
        private readonly Localizer Localizer;
        public UserRoleController(IUserRoleService userRoleService, Localizer localizer)
        {
            this.UserRoleService = userRoleService;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<UserRoleDto> Get([FromQuery] UserRoleRequest model)
        {
            return UserRoleService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(UserRoleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userRole = UserRoleService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.UserRole) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(UserRoleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userRole = UserRoleService.Edit(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.UserRole) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.UserRole) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                UserRoleService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.UserRole) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.UserRole) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
