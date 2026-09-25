using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        public CityController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<LocationDto> GetAll()
        {
            return UnitOfWork.City.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(LocationViewModel model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var cityExist = UnitOfWork.City.DoesCityExist(model.City, model.PttCode);
                    if(!cityExist)
                    {
                        var city = new City
                        {
                            Name = model.City,
                            PttCode = model.PttCode,
                            RegionId = model.RegionId
                        };
                        UnitOfWork.City.Add(city);
                        UnitOfWork.SaveChanges();
                    }

                    return Ok(new { success = true, message = Localizer.Added });
                }
                return BadRequest(new { success = false, message = ModelState });
            }
            catch(Exception e)
            {
                return BadRequest(new { success = false, message = Localizer.InternalServerError });
            }
        }
    }
}
