using System;
using System.Diagnostics;
using BenchmarkDotNet.Running;

namespace StringVSStringBuilderPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringVSStringBuilder>();
        }
    }
}
