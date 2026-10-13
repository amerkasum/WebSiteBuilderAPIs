using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class MessageUsController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IMessageUsService MessageUsService;
        public MessageUsController(Localizer localizer, IMessageUsService messageUsService)
        {
            this.Localizer = localizer;
            this.MessageUsService = messageUsService;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<MessageUsDto>> Get([FromQuery] MessageUsRequest model)
        {
            return await MessageUsService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(MessageUsViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var messageUs = await MessageUsService.AddAsync(model);
                return Ok(new { success = true, message = Localizer.MessageSent });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }        
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(MessageUsViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToString() });

            try
            {
                var messageUs = await MessageUsService.EditAsync(model);
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
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await MessageUsService.DeleteAsync(id);
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
