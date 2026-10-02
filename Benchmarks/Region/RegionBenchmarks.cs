using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Core.EF;
using Domain.DTO;
using Domain.Requests;
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

            _context = new ApplicationDbContext(options);

            if (!_context.Database.CanConnect())
            {
                throw new Exception("Could not connect to the database.");
            }

            Console.WriteLine("Database connection successful.");

            model = new RegionRequest
            {
                Search = null,
                CountryId = null
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
        public List<RegionDto> Get_v2()
        {

            var result = _context.Regions.AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(model.Search) || x.Name.Contains(model.Search))
                && (!model.CountryId.HasValue || model.CountryId == x.Country.Id))
                .Select(x => new RegionDto
                {
                    Id = x.Id,
                    CountryId = x.Country.Id,
                    Region = $"{x.Name} {x.Country.Name}"
                }).ToList();

            return result;
        }
    }
}
