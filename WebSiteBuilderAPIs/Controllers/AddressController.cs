using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;

        public AddressController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<LocationDto> GetAll()
        {
            return UnitOfWork.Address.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(LocationViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UnitOfWork.BeginTransaction();
                    var cityExist = UnitOfWork.City.DoesCityExist(model.CityName, model.PttCode);
                    var city = new City();

                    if (!cityExist)
                    {
                        city = new City
                        {
                            Name = model.CityName,
                            PttCode = model.PttCode,
                            RegionId = model.RegionId
                        };
                        UnitOfWork.City.Add(city);
                        UnitOfWork.SaveChanges();
                    }
                    else
                    {
                        city = UnitOfWork.City.GetByName(model.CityName);
                    }

                    var addressExist = UnitOfWork.Address.DoesAddressExist(model.AddressName);

                    if(!addressExist)
                    {
                        var address = new Address
                        {
                            Name = model.AddressName,
                            CityId = city.Id
                        };
                        UnitOfWork.Address.Add(address);
                        UnitOfWork.SaveChanges();
                    }
                    UnitOfWork.Commit();


                    return Ok(new { success = true, message = addressExist && cityExist ? Localizer.AlreadyExist:  string.Format(Localizer.Added, Localizer.Location) });
                }
                return BadRequest(new { success = false, message = ModelState });
            }
            catch (Exception e)
            {
                UnitOfWork.RollBack();
                return BadRequest(new { success = false, message = Localizer.InternalServerError });
            }
        }
    }
}
