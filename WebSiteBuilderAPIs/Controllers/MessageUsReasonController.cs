using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageUsReasonController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        public MessageUsReasonController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<MessageUsReason> GetAll()
        {
            return UnitOfWork.MessageUsReason.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(MessageUsReasonViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var messageUsreason = new MessageUsReason
                {
                    Name = model.Name,
                    Code = model.Code
                };

                UnitOfWork.MessageUsReason.Add(messageUsreason);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.Reason) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(MessageUsReasonViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var messageUsReason = UnitOfWork.MessageUsReason.GetById(model.Id);

                if (messageUsReason == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Reason) });

                messageUsReason.Name = model.Name;
                messageUsReason.Code = model.Code;

                UnitOfWork.MessageUsReason.Update(messageUsReason);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.Reason) });
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
                var messageUsReason = UnitOfWork.MessageUsReason.GetById(id);

                if (messageUsReason == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Reason) });

                UnitOfWork.MessageUsReason.Remove(messageUsReason);
                UnitOfWork.SaveChanges();

                return Ok(new { success= false, message = string.Format(Localizer.Deleted, Localizer.Reason) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
