using BenchmarkDotNet.Running;
using Benchmarks.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<RegionBenchmarks>();
        }       
    }
}
