using Core.Services.IService;
using Core.Services.Service;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.WebSiteBuilder;
using Domain.Pagination;
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
    public class ComponentTypeController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IComponentTypeService ComponentTypeService;
        public ComponentTypeController(Localizer localizer, IComponentTypeService componentTypeService)
        {
            this.Localizer = localizer;
            this.ComponentTypeService = componentTypeService;
        }

        [HttpGet(nameof(Get))]
        public async Task<PaginationResponse<BasicSearchResponse>> Get([FromQuery] BasicSearchRequest model)
        {
            return await ComponentTypeService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(ComponentTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var componentType = await ComponentTypeService.AddAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.ComponentType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public async Task<IActionResult> Edit(ComponentTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var componentType = await ComponentTypeService.EditAsync(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.ComponentType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ComponentType) });
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
                await ComponentTypeService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.ComponentType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ComponentType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success= false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
