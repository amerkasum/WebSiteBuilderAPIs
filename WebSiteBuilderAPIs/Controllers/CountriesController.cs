using Core.UnitOfWork;
using Domain.Entities.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork; 
        public CountriesController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Country> GetAll()
        {
            return UnitOfWork.Countries.GetAll();
        }

        [HttpGet(nameof(GetById))]
        public Country GetById(int id)
        {
            return UnitOfWork.Countries.GetById(id);
        }
    }
}
