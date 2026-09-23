using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.Location;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork UnitOfWork;
        public AddressService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public Address Add(LocationViewModel model)
        {
            try
            {
                UnitOfWork.BeginTransaction();
                var cityExist = UnitOfWork.City.DoesCityExist(model.City, model.PttCode);
                var city = new City();
                var address = new Address();

                if (!cityExist)
                {
                    city = new City
                    {
                        Name = model.City,
                        PttCode = model.PttCode,
                        RegionId = model.RegionId
                    };
                    UnitOfWork.City.Add(city);
                    UnitOfWork.SaveChanges();
                }
                else
                {
                    city = UnitOfWork.City.GetByName(model.City);
                }

                var addressExist = UnitOfWork.Address.DoesAddressExist(model.Address);

                if (!addressExist)
                {
                    address = new Address
                    {
                        Name = model.Address,
                        CityId = city.Id
                    };
                    UnitOfWork.Address.Add(address);
                    UnitOfWork.SaveChanges();
                }
                UnitOfWork.Commit();

                return address;
            }
            catch(Exception e)
            {
                UnitOfWork.RollBack();
                throw e;
            }
            
        }

        public Address Edit(LocationViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var address = UnitOfWork.Address.GetById(id);

            if (address == null)
                throw new KeyNotFoundException();

            UnitOfWork.Address.Remove(address);
            UnitOfWork.SaveChanges();
        }
    }
}
