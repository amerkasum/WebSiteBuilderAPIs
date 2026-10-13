using Core.Repositories.IRepository;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public async Task<PaginationResponse<RegionDto>> GetAsync(RegionRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.Regions.GetAsync(model);
        }

        public async Task<Region> AddAsync(RegionViewModel model)
        {
            var region = new Region
            {
                Name = model.Name,
                CountryId = model.CountryId
            };

            UnitOfWork.Regions.Add(region);
            await UnitOfWork.SaveChangesAsync();

            return region;
        }

        public async Task<Region> EditAsync(RegionViewModel model)
        {
            var region = await UnitOfWork.Regions.GetByIdAsync(model.Id);

            if (region == null)
                throw new KeyNotFoundException();

            region.Name = model.Name;
            region.CountryId = model.CountryId;

            UnitOfWork.Regions.Update(region);
            await UnitOfWork.SaveChangesAsync();

            return region;
        }

        public async Task DeleteAsync(int id)
        {
            var region = await UnitOfWork.Regions.GetByIdAsync(id);

            if (region == null)
                throw new KeyNotFoundException();

            UnitOfWork.Regions.Remove(region);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
