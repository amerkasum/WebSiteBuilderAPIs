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
    public class GenderService : IGenderService
    {
        private readonly IUnitOfWork UnitOfWork;
        public GenderService(IUnitOfWork unitOfwork)
        {
            this.UnitOfWork = unitOfwork;
        }

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.Gender.GetAsync(model);
            return result;
        }

        public async Task<Gender> AddAsync(GenderViewModel model)
        {
            var gender = new Gender
            {
                Name = model.Name,
                Code = model.Code,
                Description = model.Description
            };

            UnitOfWork.Gender.Add(gender);
            await UnitOfWork.SaveChangesAsync();

            return gender;
        }

        public async Task<Gender> EditAsync(GenderViewModel model)
        {
            var gender = UnitOfWork.Gender.GetById(model.Id);

            if (gender == null)
                throw new KeyNotFoundException();

            gender.Name = model.Name;
            gender.Code = model.Code;
            gender.Description = model.Description;

            UnitOfWork.Gender.Update(gender);
            await UnitOfWork.SaveChangesAsync();

            return gender;
        }

        public async Task DeleteAsync(int id)
        {
            var gender = UnitOfWork.Gender.GetById(id);

            if (gender == null)
                throw new KeyNotFoundException();

            UnitOfWork.Gender.Remove(gender);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
