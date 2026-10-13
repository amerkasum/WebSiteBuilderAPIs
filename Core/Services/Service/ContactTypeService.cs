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

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.ContactType.GetAsync(model);
            return result;
        }
        public async Task<ContactType> AddAsync(ContactTypeViewModel model)
        {
            var contactType = new ContactType
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.ContactType.Add(contactType);
            await UnitOfWork.SaveChangesAsync();

            return contactType;
        }

        public async Task<ContactType> EditAsync(ContactTypeViewModel model)
        {
            var contactType = await UnitOfWork.ContactType.GetByIdAsync(model.Id);

            if (contactType == null)
                throw new KeyNotFoundException();

            contactType.Name = model.Name;
            contactType.Code = model.Code;

            UnitOfWork.ContactType.Update(contactType);
            await UnitOfWork.SaveChangesAsync();

            return contactType;
        }

        public async Task DeleteAsync(int id)
        {
            var contactType = await UnitOfWork.ContactType.GetByIdAsync(id);

            if (contactType == null)
                throw new KeyNotFoundException();

            UnitOfWork.ContactType.Remove(contactType);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
