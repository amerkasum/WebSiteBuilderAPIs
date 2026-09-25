using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
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
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IAddressService AddressService;

        public AddressController(IUnitOfWork unitOfWork, Localizer localizer, IAddressService addressService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.AddressService = addressService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<LocationDto> GetAll()
        {
            return UnitOfWork.Address.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(LocationViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try 
            {
                var address = AddressService.Add(model);

                return Ok(new { success = false, message = string.Format(Localizer.Added2, Localizer.Address) });
            }
            catch (Exception e)
            {
                UnitOfWork.RollBack();
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                AddressService.Delete(id);

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
