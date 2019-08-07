using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ClassVSStruct
{
    [MemoryDiagnoser]
        public class Test
        {
            [Benchmark]
            public void TestClass()
            {
                var listOfClass = new List<Class>();

                for (int i = 0; i < 100; i++)
                    listOfClass.Add(new Class() { test = i });
            }

            [Benchmark]
            public void TestStruct()
            {
                var listOfStruct = new List<Struct>();

                for (int i = 0; i < 100; i++)
                    listOfStruct.Add(new Struct() { test = i});
            }
        }
    
}
