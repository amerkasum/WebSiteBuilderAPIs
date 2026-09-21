using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.ViewModels;
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
    public class FeedbackController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        public FeedbackController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<FeedbackDto> GetAll()
        {
            return UnitOfWork.Feedback.GetAll();
        }

        [HttpGet(nameof(GetByUserId))]
        public IEnumerable<FeedbackDto> GetByUserId(int userId)
        {
            return UnitOfWork.Feedback.GetByUserId(userId);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(FeedbackViewModel model) 
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).SelectMany(x => x.ErrorMessage).ToList() });

            try
            {
                var feedback = new Feedback
                {
                    UserId = model.UserId,
                    Message = model.Message,
                    Rating = model.Rating
                };

                UnitOfWork.Feedback.Add(feedback);
                UnitOfWork.SaveChanges();

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

            //TODO: Authorization, only logged user can chane its own feedback!

            try
            {
                var feedback = UnitOfWork.Feedback.GetById(model.Id);
                if (feedback == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Feedback) });

                feedback.Message = model.Message;
                feedback.Rating = model.Rating;

                UnitOfWork.Feedback.Update(feedback);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.Feedback) });
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
                var feedback = UnitOfWork.Feedback.GetById(id);

                if (feedback == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Feedback) });

                UnitOfWork.Feedback.Remove(feedback);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.Feedback) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
