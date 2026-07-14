using Core.UnitOfWork;
using Domain.Entities.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private IUnitOfWork UnitOfWork;
        public RegionsController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Region> GetAll()
        {
            return UnitOfWork.Regions.GetAll();
        }

        [HttpGet(nameof(GetById))]
        public Region GetById(int id) 
        {
            return UnitOfWork.Regions.GetById(id);
        }

        [HttpGet(nameof(GetByCountryId))]
        public IEnumerable<Region> GetByCountryId(int countryId)
        {
            return UnitOfWork.Regions.GetByCountryId(countryId);
        }
    }
}
