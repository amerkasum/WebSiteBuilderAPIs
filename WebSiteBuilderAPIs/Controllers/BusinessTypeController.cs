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
    public class BusinessTypeController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IBusinessTypeService BusinessTypeService;
        public BusinessTypeController(IUnitOfWork unitOfWork, Localizer localizer, IBusinessTypeService businessTypeService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.BusinessTypeService = businessTypeService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<BusinessType> GetAll()
        {
            return UnitOfWork.BusinessType.GetAll();
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
        public IActionResult Edit(BusinessTypeViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var businessType = BusinessTypeService.Edit(model);

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
        public IActionResult Delete(int id)
        {
            try
            {
                BusinessTypeService.Delete(id);

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
