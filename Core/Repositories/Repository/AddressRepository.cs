using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Location;
using Domain.Pagination;
using Domain.Requests;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context)
        {
        }

        public bool DoesAddressExist(string name, int cityId)
        {
            return _context.Addresses.Any(x => x.Name.ToLower().Equals(name.ToLower()) && x.CityId == cityId);
        }

        public async Task<PaginationResponse<AddressDto>> GetAsync(BasicSearchRequest model)
        {
            var query = _context.Addresses.AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(model.Search) || (x.Name.Contains(model.Search) || x.City.Name.Contains(model.Search) ||
                            x.City.Region.Name.Contains(model.Search) || x.City.Region.Country.Name.Contains(model.Search))) &&
                            (!x.IsDeleted && x.City.RegionId == x.City.Region.Id && x.City.Region.CountryId == x.City.Region.Country.Id));

            var totalCount = query.Count();

            var result = await query.Select(x => new AddressDto
                {
                    Id = x.Id,
                    Address = x.Name,
                    City = x.City.Name,
                    Region = x.City.Region.Name,
                    Country = x.City.Region.Country.Name,
                }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber - 1)).Take(model.PageSize).ToListAsync();

            return new PaginationResponse<AddressDto> { Data = result, PageSize = model.PageSize, PageNumber = model.PageNumber, TotalCount = totalCount,
                                                        TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize) };
        }
    }
}
