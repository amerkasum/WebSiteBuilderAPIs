using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly ICurrencyService CurrencyService;
        public CurrencyController(IUnitOfWork unitOfWork, Localizer localizer, ICurrencyService currencyService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.CurrencyService = currencyService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Currency> GetAll()
        {
            return UnitOfWork.Currency.GetAll();
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
