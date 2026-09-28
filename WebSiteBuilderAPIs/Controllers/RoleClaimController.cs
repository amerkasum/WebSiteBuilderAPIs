using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
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
    public class RoleClaimController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IRoleClaimService RoleClaimService;
        public RoleClaimController(IUnitOfWork unitOfwork, Localizer localizer, IRoleClaimService roleClaimService)
        {
            this.UnitOfWork = unitOfwork;
            this.Localizer = localizer;
            this.RoleClaimService = roleClaimService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<RoleClaim> GetAll()
        {
            return UnitOfWork.RoleClaim.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(RoleClaimViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var roleClaim = RoleClaimService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added2, Localizer.RoleClaim) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, messahe = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPost(nameof(Edit))]
        public IActionResult Edit(RoleClaimViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            try
            {
                var roleClaim = RoleClaimService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited2, Localizer.RoleClaim) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.RoleClaim) });
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
                RoleClaimService.Delete(id);
                return Ok(new { success = false, message = string.Format(Localizer.Deleted2, Localizer.RoleClaim) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.RoleClaim) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
