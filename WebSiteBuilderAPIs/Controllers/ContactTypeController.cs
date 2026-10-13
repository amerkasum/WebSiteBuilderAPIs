using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.OpenApi.Services;
using Resources.Localizer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactTypeController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IContactTypeService ContactTypeService;
        public ContactTypeController(Localizer localizer, IContactTypeService contactTypeService)
        {
            this.Localizer = localizer;
            this.ContactTypeService = contactTypeService;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<BasicSearchResponse>> Get([FromQuery] BasicSearchRequest model)
        {
            return await ContactTypeService.GetAsync(model);
        }


        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(ContactTypeViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var contactType = await ContactTypeService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.ContactType) });
            }
            catch (Exception e) {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }


        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(ContactTypeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var contactType = await ContactTypeService.EditAsync(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.ContactType) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });
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
                await ContactTypeService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.ContactType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
