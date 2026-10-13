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
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork UnitOfWork;
        public AddressService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<PaginationResponse<AddressDto>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.Address.GetAsync(model);
        }

        public async Task<Address> AddAsync(LocationViewModel model)
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
                    await UnitOfWork.SaveChangesAsync();
                }
                else
                {
                    city = UnitOfWork.City.GetByName(model.City);
                }

                var addressExist = UnitOfWork.Address.DoesAddressExist(model.Address, city.Id);

                if (!addressExist)
                {
                    address = new Address
                    {
                        Name = model.Address,
                        CityId = city.Id
                    };
                    UnitOfWork.Address.Add(address);
                    await UnitOfWork.SaveChangesAsync();
                }
                UnitOfWork.Commit();

                return address;
            }
            catch(Exception e)
            {
                UnitOfWork.RollBack();
                throw;
            }
            
        }

        public async Task<Address> EditAsync(LocationViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var address = await UnitOfWork.Address.GetByIdAsync(id);

            if (address == null)
                throw new KeyNotFoundException();

            UnitOfWork.Address.Remove(address);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
