using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class GenderService : IGenderService
    {
        private readonly IUnitOfWork UnitOfWork;
        public GenderService(IUnitOfWork unitOfwork)
        {
            this.UnitOfWork = unitOfwork;
        }
        public Gender Add(GenderViewModel model)
        {
            var gender = new Gender
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.Gender.Add(gender);
            UnitOfWork.SaveChanges();

            return gender;
        }

        public Gender Edit(GenderViewModel model)
        {
            var gender = UnitOfWork.Gender.GetById(model.Id);

            if (gender == null)
                throw new KeyNotFoundException();

            gender.Name = model.Name;
            gender.Code = model.Code;

            UnitOfWork.Gender.Update(gender);
            UnitOfWork.SaveChanges();

            return gender;
        }

        public void Delete(int id)
        {
            var gender = UnitOfWork.Gender.GetById(id);

            if (gender == null)
                throw new KeyNotFoundException();

            UnitOfWork.Gender.Remove(gender);
            UnitOfWork.SaveChanges();
        }
    }
}
