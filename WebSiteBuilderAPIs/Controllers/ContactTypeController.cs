using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.OpenApi.Services;
using Resources.Localizer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSiteBuilderAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactTypeController : ControllerBase
    {
        private readonly UnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        private readonly IContactTypeService ContactTypeService;
        public ContactTypeController(UnitOfWork unitOfWork, Localizer localizer, IContactTypeService contactTypeService)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
            this.ContactTypeService = contactTypeService;
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<ContactType> GetAll()
        {
            return UnitOfWork.ContactType.GetAll();
        }


        [HttpPost(nameof(Add))]
        public IActionResult Add(ContactTypeViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var contactType = ContactTypeService.Add(model);

                return Ok(new { success = true, message = string.Format(Localizer.Added, Localizer.ContactType) });
            }
            catch (Exception e) {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }


        [HttpPut(nameof(Edit))]
        public IActionResult Edit(ContactTypeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { success = false, message = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
                }

                var contactType = ContactTypeService.Edit(model);
                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.ContactType) });
            }
            catch (KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                ContactTypeService.Delete(id);

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.ContactType) });
            }
            catch(KeyNotFoundException)
            {
                return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
