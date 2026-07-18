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
        public MessageUsController(IUnitOfWork unitOfwork, Localizer localizer)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
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

            if(ModelState.IsValid)
            {
                MessageUs m = new MessageUs
                {
                    SenderEmail = model.EmailSender,
                    Message = model.Message,
                    MessageUsReasonId = model.MessageUsReasonId
                };

                UnitOfWork.MessageUs.Add(m);
                UnitOfWork.SaveChanges();
            }
            return Ok(new { success = true, message = Localizer.MessageSent });
        }


    }
}
