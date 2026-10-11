using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
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
    public class BusinessTypeController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IBusinessTypeService BusinessTypeService;
        public BusinessTypeController(Localizer localizer, IBusinessTypeService businessTypeService)
        {
            this.Localizer = localizer;
            this.BusinessTypeService = businessTypeService;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<BasicSearchResponse> Get([FromQuery] BasicSearchRequest model)
        {
            return BusinessTypeService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(BusinessTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var businessType = BusinessTypeService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.BusinessType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(BusinessTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var businessType = await BusinessTypeService.Edit(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.BusinessType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.BusinessType) });
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
                await BusinessTypeService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.BusinessType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.BusinessType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
