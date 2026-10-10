using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : ControllerBase
    {
        private readonly ICityService CityService;
        private readonly Localizer Localizer;
        public CityController(ICityService cityService, Localizer localizer)
        {
            this.CityService = cityService;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(Get))]
        public PaginationResponse<CityDto> Get([FromQuery] CityRequest model)
        {
            return CityService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(CityViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var city = CityService.Add(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.City) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(CityViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var city = CityService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.City) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.City) });
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
                CityService.Delete(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.City) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.City) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
