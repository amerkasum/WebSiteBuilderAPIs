using Core.Services.IService;
using Domain.DTO;
using Domain.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService UserRoleService;
        private readonly Localizer Localizer;
        public UserRoleController(IUserRoleService userRoleService, Localizer localizer)
        {
            this.UserRoleService = userRoleService;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(Get))]
        public IEnumerable<UserRoleDto> Get([FromQuery] UserRoleRequest model)
        {
            return UserRoleService.Get(model);
        }
    }
}
