using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        public SocialMediaController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<SocialMediaDto> GetAll()
        {
            return UnitOfWork.SocialMedia.GetAll();
        }

        [HttpGet(nameof(GetSocialMediaBasic))]
        public IEnumerable<SocialMediaBasicDto> GetSocialMediaBasic()
        {
            return UnitOfWork.SocialMedia.GetSocialMediaBasic();
        }



    }
}
