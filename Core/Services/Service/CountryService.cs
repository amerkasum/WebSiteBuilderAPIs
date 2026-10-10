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

        public PaginationResponse<CountryDto> Get(CountryRequest model)
        {
            model.Search = model.Search?.Trim();
            return UnitOfWork.Countries.Get(model);
        }

        public Country Add(CountryViewModel model)
        {
            var country = new Country
            {
                Name = model.Name,
                Iso = model.Iso,
            };

            UnitOfWork.Countries.Add(country);
            UnitOfWork.SaveChanges();

            return country;
        }
        public Country Edit(CountryViewModel model)
        {
            var country = UnitOfWork.Countries.GetById(model.Id);

            if (country == null)
                throw new KeyNotFoundException();

            country.Name = model.Name;
            country.Iso = model.Iso;

            UnitOfWork.Countries.Update(country);
            UnitOfWork.SaveChanges();

            return country;
        }

        public void Delete(int id)
        {
            var country = UnitOfWork.Countries.GetById(id);

            if (country == null)
                throw new KeyNotFoundException();

            UnitOfWork.Countries.Remove(country);
            UnitOfWork.SaveChanges();
        }      
    }
}
