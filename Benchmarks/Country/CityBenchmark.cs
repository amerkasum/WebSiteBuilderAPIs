using BenchmarkDotNet.Attributes;
using Core.EF;
using Domain.DTO;
using Domain.Pagination;
using Domain.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Country
{
    [MemoryDiagnoser]
    public class CityBenchmark
    {
        private ApplicationDbContext _context = null;
        private CityRequest model = null;
        private IHttpContextAccessor httpContextaccessor;
        [GlobalSetup]
        public void Setup()
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            _context = new ApplicationDbContext(options, httpContextaccessor);

            if (!_context.Database.CanConnect())
            {
                throw new Exception("Could not connect to the database.");
            }

            Console.WriteLine("Database connection successful.");

            model = new CityRequest
            {
                Search = null,
                RegionId = null,
                CountryId = null,
                PageSize = 100,
                PageNumber = 1
            };
        }

        [Benchmark(Baseline = true)]
        public PaginationResponse<CityDto> Get_v1()
        {
            var query = _context.Cities.Include(x => x.Region).ThenInclude(x => x.Country).AsNoTracking()
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

            return new PaginationResponse<CityDto>
            {
                Data = result,
                TotalCount = totalCount,
                PageNumber = model.PageNumber,
                PageSize = model.PageSize,
                TotalPages = (int)Math.Ceiling((double)totalCount / model.PageSize)
            };
        }

        [Benchmark]
        public PaginationResponse<CityDto> Get_v2()
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

            return new PaginationResponse<CityDto>
            {
                Data = result,
                TotalCount = totalCount,
                PageNumber = model.PageNumber,
                PageSize = model.PageSize,
                TotalPages = (int)Math.Ceiling((double)totalCount / model.PageSize)
            };
        }
    }
}
