using Core.Services.IService;
using Core.UnitOfWork;
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
    public class UserSocialMediaController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IUserSocialMediaService UserSocialMediaService;
        public UserSocialMediaController(Localizer localizer, IUserSocialMediaService userSocialMediaService)
        {
            this.Localizer = localizer;
            this.UserSocialMediaService = userSocialMediaService;
        }


        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<UserSocialMediaDto>> Get([FromQuery] UserSocialMediaRequest model)
        {
            return await UserSocialMediaService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(UserSocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userSocialMedia = await UserSocialMediaService.AddAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(UserSocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).SelectMany(x => x.ErrorMessage).ToList() });

            try
            {
                var userSocialMedia = await UserSocialMediaService.EditAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.SocialMedia) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.SocialMedia) });
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
                await UserSocialMediaService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.SocialMedia) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
