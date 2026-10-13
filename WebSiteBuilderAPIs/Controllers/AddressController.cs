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
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        private readonly Localizer Localizer;
        private readonly IAddressService AddressService;

        public AddressController(Localizer localizer, IAddressService addressService)
        {
            this.Localizer = localizer;
            this.AddressService = addressService;
        }

        [HttpGet(nameof(GetAsync))]
        public async Task<PaginationResponse<AddressDto>> GetAsync([FromQuery] BasicSearchRequest model)
        {
            return await AddressService.GetAsync(model);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(LocationViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try 
            {
                var address = await AddressService.AddAsync(model);

                return Ok(new { success = false, message = string.Format(Localizer.Added2, Localizer.Address) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await AddressService.DeleteAsync(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.Location) });  
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound2, Localizer.Address) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
