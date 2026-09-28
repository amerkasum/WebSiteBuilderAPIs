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
    public class ClaimController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IClaimService ClaimService;
        public ClaimController(IUnitOfWork unitOfWork, Localizer localizer, IClaimService claimService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.ClaimService = claimService;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<BasicSearchResponse> Get([FromQuery] BasicSearchRequest model)
        {
            return ClaimService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(ClaimViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var claim = ClaimService.Add(model);
                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.Claim) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(ClaimViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var claim = ClaimService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.Claim) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Claim) });
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
                ClaimService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted2, Localizer.Claim) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest( new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Claim) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
