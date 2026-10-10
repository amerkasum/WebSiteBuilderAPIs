using Azure;
using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext context) : base(context)
        {
        }

        public PaginationResponse<CityDto> Get(CityRequest model)
        {
            var query = _context.Cities.AsNoTracking()
                .Where(x => !x.IsDeleted && (string.IsNullOrEmpty(model.Search) || x.Name.Contains(model.Search)) &&
                (!model.RegionId.HasValue || x.Region.Id == model.RegionId)
                && (!model.CountryId.HasValue || model.CountryId == x.Region.Country.Id));

            var totalCount = query.Count();

            var result = query.Select(x => new CityDto
            {
                Id = x.Id,
                Name = x.Name,
                PttCode = x.PttCode,
                RegionCountry = $"{x.Region.Name}, {x.Region.Country.Name}",
                RegionId = x.Region.Id,
                CountryId = x.Region.Country.Id
            }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber - 1)).Take(model.PageSize).ToList();

            return new PaginationResponse<CityDto> { Data = result, TotalCount = totalCount, PageNumber = model.PageNumber,
            PageSize = model.PageSize, TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize) };
        }
        
        public bool DoesCityExist(string name, string pttCode)
        {
            return _context.Cities.Any(x => x.Name.ToLower().Equals(name.ToLower()) && x.PttCode.ToLower().Equals(pttCode));
        }

        public City GetByName(string name)
        {
            return _context.Cities.FirstOrDefault(x => x.Name.ToLower().Equals(name.ToLower()));
        }
    }
}
