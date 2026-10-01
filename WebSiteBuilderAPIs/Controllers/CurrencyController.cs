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
    public class CurrencyController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly ICurrencyService CurrencyService;
        public CurrencyController(Localizer localizer, ICurrencyService currencyService)
        {
            this.Localizer = localizer;
            this.CurrencyService = currencyService;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<CurrencyDto> Get([FromQuery] BasicSearchRequest model)
        {
            return CurrencyService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(CurrencyViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var currency = CurrencyService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.Currency) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(CurrencyViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var currency = CurrencyService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.Currency) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Currency) });
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
                CurrencyService.Delete(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.Currency) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Currency)});
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
