using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly ISocialMediaService SocialMediaService;
        public SocialMediaController(IUnitOfWork unitOfWork, Localizer localizer, ISocialMediaService socialMediaService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.SocialMediaService = socialMediaService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<SocialMediaDto> GetAll()
        {
            return UnitOfWork.SocialMedia.GetAll();
        }

        [HttpGet(nameof(GetSocialMediaBasic))]
        public IEnumerable<SocialMediaBasicDto> GetSocialMediaBasic()
        {
            return UnitOfWork.SocialMedia.GetSocialMediaBasic();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(SocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var socialMedia = SocialMediaService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(SocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var socialMedia = SocialMediaService.Edit(model);
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
        public IActionResult Delete(int id)
        {
            try
            {
                SocialMediaService.Delete(id);
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
