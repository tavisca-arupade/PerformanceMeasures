using BenchmarkDotNet.Running;
using System;

namespace TaskVSThreadPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TaskVSThread>();
        }
    }
}
