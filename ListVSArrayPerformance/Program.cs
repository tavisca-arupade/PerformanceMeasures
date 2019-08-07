using System;
using BenchmarkDotNet.Running;

namespace ListVSArrayPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListVSArray>();
        }
    }
}
