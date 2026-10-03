using Core.EF;
using Core.EF.Seed;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public PaginationResponse<RegionDto> Get(RegionRequest model)
        {

            var query = _context.Regions.AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(model.Search) || x.Name.Contains(model.Search))
                && (!model.CountryId.HasValue || model.CountryId == x.Country.Id));

            var totalCount = query.Count();

            var result = query.Select(x => new RegionDto
            {
                Id = x.Id,
                CountryId = x.Country.Id,
                Region = $"{x.Name} {x.Country.Name}"
            }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber - 1)).Take(model.PageSize).ToList();

            return new PaginationResponse<RegionDto> { Data = result, PageNumber = model.PageNumber, PageSize = model.PageSize, TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize)
            };
        }

        public IEnumerable<Region> GetByCountryId(int countryId)
        {
            return _context.Regions.Where(x => x.CountryId == countryId).ToList();
        }
    }
}
