using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ForVSForeachPerformance
{
    [MemoryDiagnoser]
    public class ForVSForeach
    {

        List<int> list1 = new List<int> { };
        List<int> list2 = new List<int> { };
        List<int> list3 = new List<int> { };

        public void Initialize()
        {
            for (int i = 0; i < 1000; i++)
            {
                list1.Add(i);
            }
        }

        [Benchmark]
        public void TestForLoop()
        {
            for (int iterator = 0; iterator < list1.Count; iterator++)
            {
                list2.Add(list1[iterator]);
            }
        }

        [Benchmark]
        public void TestForeachLoop()
        {
            foreach (var number in list1)
            {
                list3.Add(number);
            }
        }
    }


}
