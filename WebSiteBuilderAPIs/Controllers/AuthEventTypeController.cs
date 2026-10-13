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
    public class AuthEventTypeController : ControllerBase
    {
        private readonly IAuthEventTypeService AuthEventTypeService;
        private readonly Localizer Localizer;
        public AuthEventTypeController(IAuthEventTypeService authEventTypeService, Localizer localizer)
        {
            this.AuthEventTypeService = authEventTypeService;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<AuthEventTypeDto>> Get(AuthEventTypeRequest model)
        {
            return await AuthEventTypeService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(AuthEventTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var authEventType = await AuthEventTypeService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.AuthEventType) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(AuthEventTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var euathEventType = await AuthEventTypeService.EditAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.AuthEventType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.AuthEventType) });
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
                await AuthEventTypeService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.AuthEventType) });
            }
            catch(KeyNotFoundException)
            {
                 return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.AuthEventType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
