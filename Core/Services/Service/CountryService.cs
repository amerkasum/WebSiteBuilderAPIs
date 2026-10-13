using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork UnitOfWork;
        public CountryService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<PaginationResponse<CountryDto>> GetAsync(CountryRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.Countries.GetAsync(model);
        }

        public async Task<Country> AddAsync(CountryViewModel model)
        {
            var country = new Country
            {
                Name = model.Name,
                Iso = model.Iso,
            };

            UnitOfWork.Countries.Add(country);
            await UnitOfWork.SaveChangesAsync();

            return country;
        }
        public async Task<Country> EditAsync(CountryViewModel model)
        {
            var country = await UnitOfWork.Countries.GetByIdAsync(model.Id);

            if (country == null)
                throw new KeyNotFoundException();

            country.Name = model.Name;
            country.Iso = model.Iso;

            UnitOfWork.Countries.Update(country);
            await UnitOfWork.SaveChangesAsync();

            return country;
        }

        public async Task DeleteAsync(int id)
        {
            var country = await UnitOfWork.Countries.GetByIdAsync(id);

            if (country == null)
                throw new KeyNotFoundException();

            UnitOfWork.Countries.Remove(country);
            await UnitOfWork.SaveChangesAsync();
        }      
    }
}
