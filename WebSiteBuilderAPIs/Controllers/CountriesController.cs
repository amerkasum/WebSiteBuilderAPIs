using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.FileProviders.Physical;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService CountryService;
        private readonly Localizer Localizer;
        public CountriesController(ICountryService countryService, Localizer localizer)
        {
            this.CountryService = countryService;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(Get))]
        public PaginationResponse<CountryDto> Get([FromQuery] CountryRequest model)
        {
            return CountryService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(CountryViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var country = CountryService.Add(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.Country) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(CountryViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success =false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            
            try
            {
                var country = CountryService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.Country) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Country) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int id)
        {
            try
            {
                CountryService.Delete(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.Country) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.Deleted2, Localizer.Country)  });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
