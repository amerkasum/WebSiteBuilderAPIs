using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessageUsReasonController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IMessageUsReasonService MessageUsReasonService;
        public MessageUsReasonController(Localizer localizer, IMessageUsReasonService messageUsReasonService)
        {
            this.Localizer = localizer;
            this.MessageUsReasonService = messageUsReasonService;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<BasicSearchResponse>> Get([FromQuery] BasicSearchRequest model)
        {
            return await MessageUsReasonService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(MessageUsReasonViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var messageUsreason = await MessageUsReasonService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.Reason) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(MessageUsReasonViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var messageUsReason = await MessageUsReasonService.EditAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.Reason) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Reason) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await MessageUsReasonService.DeleteAsync(id);

                return Ok(new { success= false, message = string.Format(Localizer.Deleted, Localizer.Reason) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Reason) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
