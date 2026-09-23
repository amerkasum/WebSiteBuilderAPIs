using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.Personal;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserContactService : IUserContactService
    {
        private readonly IUnitOfWork UnitOfWork;
        public UserContactService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public UserContact Add(UserContactViewModel model)
        {
            var userContact = new UserContact
            {
                UserId = model.UserId,
                ContactTypeId = model.ContactTypeId,
                Value = model.Value
            };

            UnitOfWork.UserContact.Add(userContact);
            UnitOfWork.SaveChanges();

            return userContact;
        }

        public UserContact Edit(UserContactViewModel model)
        {
            var userContact = UnitOfWork.UserContact.GetById(model.Id);

            if (userContact == null)
                throw new KeyNotFoundException();

            userContact.UserId = model.UserId;
            userContact.ContactTypeId = model.ContactTypeId;
            userContact.Value = model.Value;

            UnitOfWork.UserContact.Update(userContact);
            UnitOfWork.SaveChanges();

            return userContact;
        }

        public void Delete(int id)
        {
            var userContact = UnitOfWork.UserContact.GetById(id);

            if (userContact == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserContact.Remove(userContact);
            UnitOfWork.SaveChanges();
        }

        
    }
}
