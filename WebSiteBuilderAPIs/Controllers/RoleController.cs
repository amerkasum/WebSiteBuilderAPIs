using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resources.Localizer;

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        public RoleController(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Role> GetAll()
        {
            return UnitOfWork.Role.GetAll();
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(GenderViewModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(new { success= false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var gender = new Gender
                {
                    Name = model.Name,
                    Code = model.Code
                };

                UnitOfWork.Gender.Add(gender);
                UnitOfWork.SaveChanges();

                return Ok(new { success = false, message = string.Format(Localizer.Added, Localizer.Gender) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }

        [HttpPut(nameof(Edit))]
        public IActionResult Edit(GenderViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });

            try
            {
                var gender = UnitOfWork.Gender.GetById(model.Id);

                if (gender == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Gender) });

                gender.Name = model.Name;
                gender.Code = model.Code;

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.Gender) });
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
                var gender = UnitOfWork.Gender.GetById(id);

                if (gender == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.Gender) });

                UnitOfWork.Gender.Remove(gender);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.Gender) });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
