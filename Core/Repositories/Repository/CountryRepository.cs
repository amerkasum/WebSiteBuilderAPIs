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
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public PaginationResponse<CountryDto> Get(CountryRequest model)
        {
            var query = _context.Countries.AsNoTracking()
                .Where(x => !x.IsDeleted &&
                (string.IsNullOrEmpty(model.Search) || (x.Name.Contains(model.Search) || x.Iso.Contains(model.Search))));

            var totalCount = query.Count();

            var result = query.Select(x => new CountryDto
            {
                Id = x.Id,
                Name = x.Name,
                Iso = x.Iso,
            }).OrderBy(x => x.Id).Skip(model.PageSize * (model.PageNumber -1)).Take(model.PageSize).ToList();

            return new PaginationResponse<CountryDto> { Data = result, TotalCount = totalCount,
                PageSize = model.PageSize, PageNumber = model.PageNumber,
                TotalPages = (int)Math.Ceiling((double)totalCount/model.PageSize)
            };

        }
    }
}
