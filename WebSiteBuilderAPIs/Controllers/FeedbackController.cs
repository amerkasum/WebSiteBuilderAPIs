using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Identity.Client;
using Resources.Localizer;
using System.Runtime.CompilerServices;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FeedbackController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IFeedbackService FeedbackService;
        public FeedbackController(Localizer localizer, IFeedbackService feedbackService)
        {
            this.Localizer = localizer;
            this.FeedbackService = feedbackService;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<FeedbackDto> Get([FromQuery] BasicSearchRequest model)
        {
            return FeedbackService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(FeedbackViewModel model) 
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).SelectMany(x => x.ErrorMessage).ToList() });

            try
            {
                var feedback = FeedbackService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.Feedback) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(FeedbackViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            //TODO: Authorization, only logged user can change its own feedback!

            try
            {
                var feedback = FeedbackService.Edit(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.Feedback) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Feedback) });
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
                FeedbackService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.Feedback) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Feedback) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
