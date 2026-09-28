using Core.Repositories.IRepository;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class ContactTypeService : IContactTypeService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ContactTypeService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = UnitOfWork.ContactType.Get(model);
            return result;
        }
        public ContactType Add(ContactTypeViewModel model)
        {
            var contactType = new ContactType
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.ContactType.Add(contactType);
            UnitOfWork.SaveChanges();

            return contactType;
        }

        public ContactType Edit(ContactTypeViewModel model)
        {
            var contactType = UnitOfWork.ContactType.GetById(model.Id);

            if (contactType == null)
                throw new KeyNotFoundException();

            contactType.Name = model.Name;
            contactType.Code = model.Code;

            UnitOfWork.ContactType.Update(contactType);
            UnitOfWork.SaveChanges();

            return contactType;
        }

        public void Delete(int id)
        {
            var contactType = UnitOfWork.ContactType.GetById(id);

            if (contactType == null)
                throw new KeyNotFoundException();

            UnitOfWork.ContactType.Remove(contactType);
            UnitOfWork.SaveChanges();
        }
    }
}
