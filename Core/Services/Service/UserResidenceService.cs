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
    public class UserResidenceService : IUserResidenceService
    {
        private readonly IUnitOfWork UnitOfWork;
        public UserResidenceService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<UserResidence> AddAsync(UserResidenceViewModel model)
        {
            var userResidence = new UserResidence
            {
                UserId = model.UserId,
                AddressId = model.AddressId,
                IsPrimary = model.IsPrimary
            };

            UnitOfWork.UserResidence.Add(userResidence);
            await UnitOfWork.SaveChangesAsync();

            return userResidence;
        }

        public async Task<UserResidence> EditAsync(UserResidenceViewModel model)
        {
            var userResidence = UnitOfWork.UserResidence.GetById(model.Id);

            if (userResidence == null)
                throw new KeyNotFoundException();

            userResidence.AddressId = model.AddressId;
            userResidence.IsPrimary = model.IsPrimary;

            UnitOfWork.UserResidence.Update(userResidence);
            await UnitOfWork.SaveChangesAsync();

            return userResidence;
        }

        public async Task DeleteAsync(int id)
        {
            var userResidence = UnitOfWork.UserResidence.GetById(id);

            if (userResidence == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserResidence.Remove(userResidence);
            await UnitOfWork.SaveChangesAsync();
        }

        
    }
}
