using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
using Domain.ViewModels;
using Helpers.Helpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        private readonly IAuditLogService AuditLogService;
        public UserContactService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<IEnumerable<UserContactDto>> GetAsync(UserContactRequest model)
        {
            model.Sreach = model.Sreach?.Trim();
            return await UnitOfWork.UserContact.GetAsync(model);
        }

        public async Task<UserContact> AddAsync(UserContactViewModel model)
        {
            var userContact = new UserContact
            {
                UserId = model.UserId,
                ContactTypeId = model.ContactTypeId,
                Value = model.Value
            };

            UnitOfWork.UserContact.Add(userContact);
            await UnitOfWork.SaveChangesAsync();

            return userContact;
        }

        public async Task<UserContact> EditAsync(UserContactViewModel model)
        {
            var userContact = UnitOfWork.UserContact.GetById(model.Id);

            if (userContact == null)
                throw new KeyNotFoundException();

            userContact.UserId = model.UserId;
            userContact.ContactTypeId = model.ContactTypeId;
            userContact.Value = model.Value;

            UnitOfWork.UserContact.Update(userContact);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return userContact;
        }

        public async Task DeleteAsync(int id)
        {
            var userContact = UnitOfWork.UserContact.GetById(id);

            if (userContact == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserContact.Remove(userContact);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }

        public List<UserContact> HandleUserContacts(List<UserContactViewModel> userContactsModel, int userId, string email)
        {
            List<UserContact> userContacts = new List<UserContact>();
            userContactsModel.Add(new UserContactViewModel
            {
                UserId = userId,
                ContactTypeId = (int)Enumerations.ContactTypes.EMAIL,
                Value = email
            });

            userContactsModel.ForEach(x => 
            {
                var userContact = new UserContact
                {
                    UserId = userId,
                    ContactTypeId = x.ContactTypeId,
                    Value = x.Value
                };

                userContacts.Add(userContact);
            });

            UnitOfWork.UserContact.AddRange(userContacts);
            UnitOfWork.SaveChanges();

            return userContacts;
        }
    }
}
