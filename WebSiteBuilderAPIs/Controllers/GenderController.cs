using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Localization;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IGenderService GenderService;
        public GenderController(IUnitOfWork unitOfWork, Localizer localizer, IGenderService genderService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.GenderService = genderService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Gender> GetAll()
        {
            return UnitOfWork.Gender.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(GenderViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var gender = GenderService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.Gender) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(GenderViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var gender = GenderService.Edit(model);

                return Ok(new { success = false, message = string.Format(Localizer.Edited, Localizer.Gender) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Gender) });
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
                GenderService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.Gender) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Gender) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
