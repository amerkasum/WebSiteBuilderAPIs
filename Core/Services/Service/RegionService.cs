using Core.Repositories.IRepository;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class RegionService : IRegionService
    {
        private readonly IUnitOfWork UnitOfWork;
        public RegionService(IUnitOfWork unitOFWork)
        {
            this.UnitOfWork = unitOFWork;
        }

        public IEnumerable<RegionDto> Get(RegionRequest model)
        {
            model.Search = model.Search?.Trim();
            return UnitOfWork.Regions.Get(model);
        }

        public Region Add(RegionViewModel model)
        {
            var region = new Region
            {
                Name = model.Name,
                CountryId = model.CountryId
            };

            UnitOfWork.Regions.Add(region);
            UnitOfWork.SaveChanges();

            return region;
        }

        public Region Edit(RegionViewModel model)
        {
            var region = UnitOfWork.Regions.GetById(model.Id);

            if (region == null)
                throw new KeyNotFoundException();

            region.Name = model.Name;
            region.CountryId = model.CountryId;

            UnitOfWork.Regions.Update(region);
            UnitOfWork.SaveChanges();

            return region;
        }

        public void Delete(int id)
        {
            var region = UnitOfWork.Regions.GetById(id);

            if (region == null)
                throw new KeyNotFoundException();

            UnitOfWork.Regions.Remove(region);
            UnitOfWork.SaveChanges();
        }
    }
}
