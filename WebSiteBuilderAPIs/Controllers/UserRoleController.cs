using Core.Services.IService;
using Domain.DTO;
using Domain.Pagination;
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
        public async Task<PaginationResponse<UserRoleDto>> Get([FromQuery] UserRoleRequest model)
        {
            return await UserRoleService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(UserRoleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userRole = await UserRoleService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.UserRole) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(UserRoleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userRole = await UserRoleService.EditAsync(model);

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
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await UserRoleService.DeleteAsync(id);

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
