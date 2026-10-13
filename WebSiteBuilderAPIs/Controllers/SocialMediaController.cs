using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SocialMediaController : Controller
    {
        private readonly Localizer Localizer;
        private readonly ISocialMediaService SocialMediaService;
        public SocialMediaController(Localizer localizer, ISocialMediaService socialMediaService)
        {
            this.Localizer = localizer;
            this.SocialMediaService = socialMediaService;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<BasicSearchResponse>> Get([FromQuery] BasicSearchRequest model)
        {
            return await SocialMediaService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(SocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var socialMedia = await SocialMediaService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(SocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var socialMedia = await SocialMediaService.EditAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.SocialMedia) });            
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.SocialMedia) });
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
                await SocialMediaService.DeleteAsync(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.SocialMedia) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.SocialMedia) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
