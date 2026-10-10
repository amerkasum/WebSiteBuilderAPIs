using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
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

namespace Benchmarks.Region
{
    [MemoryDiagnoser]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
    public class RegionBenchmarks
    {
        private ApplicationDbContext _context = null;
        private RegionRequest model = null;
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

            model = new RegionRequest
            {
                Search = null,
                CountryId = null,
                PageSize = 100,
                PageNumber = 1
            };
        }

        [Benchmark(Baseline = true)]
        public List<RegionDto> Get_v1()
        {
            var result = _context.Regions.AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(model.Search) || x.Name.Contains(model.Search))
                && (!model.CountryId.HasValue || model.CountryId == x.Country.Id))
                .Select(x => new RegionDto
                {
                    Id = x.Id,
                    CountryId = x.Country.Id,
                    Region = $"{x.Name}, {x.Country.Name}",
                }).ToList();

            return result;
        }

        [Benchmark]
        public PaginationResponse<RegionDto> Get()
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

            return new PaginationResponse<RegionDto>
            {
                Data = result,
                PageNumber = model.PageNumber,
                PageSize = model.PageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((double)totalCount / model.PageSize)
            };
        }
    }
}
