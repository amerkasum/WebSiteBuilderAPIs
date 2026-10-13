using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Personal;
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
    public class UserContactController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IUserContactService UserContactService;
        public UserContactController(Localizer localizer, IUserContactService userContactService)
        {
            this.Localizer = localizer;
            this.UserContactService = userContactService;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<UserContactDto>> Get([FromQuery] UserContactRequest model)
        {
            return await UserContactService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(UserContactViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var userContact = await UserContactService.AddAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.UserContact) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(UserContactViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var userContact = await UserContactService.EditAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.UserContact) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.UserContact) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await UserContactService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.UserContact) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest (new { success = false, message = string.Format(Localizer.NotFound, Localizer.UserContact) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

    }
}
