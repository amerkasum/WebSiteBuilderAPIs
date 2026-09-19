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
        public ContactTypeController(UnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
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

                var contactType = new ContactType
                {
                    Name = model.Name,
                    Code = model.Code
                };

                UnitOfWork.ContactType.Add(contactType);
                UnitOfWork.SaveChanges();

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

                var contactType = UnitOfWork.ContactType.GetById(model.Id);

                if(contactType == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });

                contactType.Name = model.Name;
                contactType.Code = model.Code;

                UnitOfWork.ContactType.Update(contactType);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Edited, Localizer.ContactType) });
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
                var contactType = UnitOfWork.ContactType.GetById(id);

                if (contactType == null)
                    return BadRequest(new { success = false, message = string.Format(Localizer.NotFound, Localizer.ContactType) });

                UnitOfWork.ContactType.Remove(contactType);
                UnitOfWork.SaveChanges();

                return Ok(new { success = true, message = string.Format(Localizer.Deleted, Localizer.ContactType) });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { success = false, message = string.Format(Localizer.SomethingWentWrong, e.Message) });
            }
        }
    }
}
