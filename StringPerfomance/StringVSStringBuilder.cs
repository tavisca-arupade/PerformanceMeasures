using System.Text;

using BenchmarkDotNet.Attributes;

namespace StringVSStringBuilderPerformance
{
    [MemoryDiagnoser]
    public class StringVSStringBuilder
    {

        [Benchmark]
        public void TestString()
        {
            string someString = "hello";
            for (int i=0; i < 100;i++)
                someString += "world";
        }
        [Benchmark]
        public void TestStringBuilder()
        {
            StringBuilder someBuilder = new StringBuilder("hello");
            for (int i = 0; i < 100; i++)
                someBuilder.Append("world");

        }
    }
}
