using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ListVSArrayPerformance
{
    [MemoryDiagnoser]
    [RPlotExporter, RankColumn]
    public class ListVSArray
    {
        [Benchmark]
        public void TestArray()
        {
            var array = new int[100];

            for (int i = 0; i < 100; i++)
                array[i] = i;
        }

        [Benchmark]
        public void TestList()
        {
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
                list.Add(i);
        }
    }
}
