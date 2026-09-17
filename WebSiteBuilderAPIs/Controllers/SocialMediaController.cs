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
        public SocialMediaController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
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
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var socialMedia = new SocialMedia
                {
                    Name = model.Name,
                    Icon = model.Icon,
                    Code = model.Code,
                    Color = model.Color
                };

                var highestDisplayOrder = UnitOfWork.SocialMedia.GetHighestDisplayOrder();
                socialMedia.DisplayOrder = highestDisplayOrder + 1;

                UnitOfWork.SocialMedia.Add(socialMedia);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.SocialMedia) });
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [HttpPatch(nameof(Edit))]
        public IActionResult Edit(SocialMediaViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var socialMedia = UnitOfWork.SocialMedia.GetById(model.Id);

                if(socialMedia != null)
                {
                    socialMedia.Name = model.Name;
                    socialMedia.Icon = model.Icon;
                    socialMedia.Code = model.Code;
                    socialMedia.Color = model.Color;
                    socialMedia.DisplayOrder = model.DisplayOrder;

                    UnitOfWork.SocialMedia.Update(socialMedia);
                    UnitOfWork.SaveChanges();

                    return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.SocialMedia) });
                }

                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.SocialMedia) });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var socialMedia = UnitOfWork.SocialMedia.GetById(id);

                if(socialMedia == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.SocialMedia) });

                UnitOfWork.SocialMedia.Remove(socialMedia);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.SocialMedia) });
                
            }
            catch(Exception e)
            {
                throw e;
            }
        }



    }
}
