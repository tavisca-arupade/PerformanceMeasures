using BenchmarkDotNet.Running;
using System;

namespace ForVSForeachPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ForVSForeach>();
        }
    }


}
