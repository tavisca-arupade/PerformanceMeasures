using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;

namespace TaskVSThreadPerformance
{
    [MemoryDiagnoser]
    public class TaskVSThread
    {
        public void AddDelay20()
        {
            Thread.Sleep(20);
        }

        public void AddDelay30()
        {
            Thread.Sleep(30);
        }

        public async static Task AddTaskDelay20()
        {
            await Task.Delay(20);

        }

        public async static Task AddTaskDelay30()
        {
            await Task.Delay(30);
        }

        [Benchmark]
        public void TestThread()
        {
            Thread thread1 = new Thread(() => AddDelay20());
            Thread thread2 = new Thread(() => AddDelay30());

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        [Benchmark]
        public void TestTask()
        {
            Task.Run(async () =>
            {
                var task1 = AddTaskDelay20();
                var task2 = AddTaskDelay30();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();
        }
    }
}
