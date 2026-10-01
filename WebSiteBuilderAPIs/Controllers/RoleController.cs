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
    public class RoleController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IRoleService RoleService;
        public RoleController(Localizer localizer, IRoleService roleService)
        {
            this.Localizer = localizer;
            this.RoleService = roleService;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<BasicSearchResponse> Get([FromQuery] BasicSearchRequest model)
        {
            return RoleService.Get(model);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(RoleViewModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var role = RoleService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.Role) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(RoleViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var role = RoleService.Edit(model);

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.Role) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Role) });
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
                RoleService.Delete(id);
                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.Role) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Role) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
