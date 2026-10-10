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
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork UnitOfWork;
        public CityService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public PaginationResponse<CityDto> Get(CityRequest model)
        {
            model.Search = model.Search?.Trim();
            return UnitOfWork.City.Get(model);
        }
        public City Add(CityViewModel model)
        {
            var city = new City
            {
                Name = model.Name,
                PttCode = model.PttCode,
                RegionId = model.RegionId
            };

            UnitOfWork.City.Add(city);
            UnitOfWork.SaveChanges();

            return city;
        }

        public City Edit(CityViewModel model)
        {
            var city = UnitOfWork.City.GetById(model.Id);

            if (city == null)
                throw new KeyNotFoundException();

            city.Name = model.Name;
            city.PttCode = model.PttCode;
            city.RegionId = model.RegionId;

            UnitOfWork.City.Update(city);
            UnitOfWork.SaveChanges();

            return city;
        }

        public void Delete(int id)
        {
            var city = UnitOfWork.City.GetById(id);

            if (city == null)
                throw new KeyNotFoundException();

            UnitOfWork.City.Remove(city);
            UnitOfWork.SaveChanges();
        }
    }
}
