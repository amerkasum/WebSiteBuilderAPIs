using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSocialMediaController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IUserSocialMediaService UserSocialMediaService;
        public UserSocialMediaController(IUnitOfWork unitOfWork, Localizer localizer, IUserSocialMediaService userSocialMediaService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.UserSocialMediaService = userSocialMediaService;
        }


        [HttpGet(nameof(GetByUserId))]
        public List<UserSocialMediaDto> GetByUserId(int userId)
        {
            return UserSocialMediaService.GetByUserId(userId);
        }

        [HttpGet(nameof(GetAll))]
        public List<UserSocialMediaDto> GetAll()
        {
            return UserSocialMediaService.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(UserSocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var userSocialMedia = UserSocialMediaService.Add(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(UserSocialMediaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).SelectMany(x => x.ErrorMessage).ToList() });

            try
            {
                var userSocialMedia = UserSocialMediaService.Edit(model);
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
        public IActionResult Delete(int id)
        {
            try
            {
                UserSocialMediaService.Delete(id);

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
