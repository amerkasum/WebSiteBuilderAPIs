using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.WebSiteBuilder;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentTypeController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IComponentTypeService ComponentTypeService;
        public ComponentTypeController(IUnitOfWork unitOfwork, Localizer localizer, IComponentTypeService componentTypeService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.ComponentTypeService = componentTypeService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<ComponentType> GetAll()
        {
            return UnitOfWork.ComponentType.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(ComponentTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var componentType = ComponentTypeService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.ComponentType) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(ComponentTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var componentType = ComponentTypeService.Edit(model);

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
        public IActionResult Delete(int id)
        {
            try
            {
                ComponentTypeService.Delete(id);

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
