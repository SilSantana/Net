using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace DemoTeste
{
    public static class Program
    {
     
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());


    }


    [MemoryDiagnoser]
    public class Benchmarks
    {
        const int NumOfIterations = 1;

        [Benchmark]
        public int IList()
        {
            int sum = 0;
            IList<int> numbers = new List<int> { 0 };

            for (int i = 0; i < NumOfIterations; i++)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }

        [Benchmark]
        public int IEnumerable()
        {
            int sum = 0;
            IEnumerable<int> numbers = new List<int> { 0 };

            for (int i = 0; i < NumOfIterations; i++)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }


        [Benchmark]
        public int List()
        {
            int sum = 0;
            List<int> numbers = new List<int> { 0 };

            for (int i = 0; i < NumOfIterations; i++)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }


    }

}