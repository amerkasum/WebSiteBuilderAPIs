using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Resources;
using Resources.Localizer;
using Resources.Localizer.Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageUsController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IMessageUsService MessageUsService;
        public MessageUsController(IUnitOfWork unitOfwork, Localizer localizer, IMessageUsService messageUsService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.MessageUsService = messageUsService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<MessageUs> GetAll()
        {
            return UnitOfWork.MessageUs.GetAll();
        }

        [HttpGet(nameof(GetallWithParameters))]
        public List<MessageUsDto> GetallWithParameters(string? senderEmail, int? messageUsReasonId, DateTime? dateFrom, DateTime? dateTo)
        {
            return UnitOfWork.MessageUs.GetAllWithParameters(senderEmail, messageUsReasonId, dateFrom, dateTo).ToList();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(MessageUsViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var messageUs = MessageUsService.Add(model);
                return Ok(new { success = true, message = Localizer.MessageSent });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }        
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(MessageUsViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToString() });

            try
            {
                var messageUs = MessageUsService.Edit(model);
                return Ok(new { success = true, message = Localizer.MessageSent });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Message) });
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
                MessageUsService.Delete(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.Message) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Message) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }


    }
}
