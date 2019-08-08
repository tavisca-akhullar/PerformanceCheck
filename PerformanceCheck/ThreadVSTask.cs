using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using System.Threading;

namespace PerformanceCheck
{
    public class ThreadVSTask
    {
        [Benchmark]
        public void ThreadTest()
        {
            Thread thread1 = new Thread(WaitThreadForSmallTime);
            Thread thread2 = new Thread(WaitThreadForLongTime);

        }

        [Benchmark]
        public void TaskTest()
        {
            Task.Run(async () =>
            {
                Task task1 = WaitTaskForSmallTime();
                Task task2 = WaitTaskForLongTime();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();
        }


        public static void WaitThreadForSmallTime()
        {
            Thread.Sleep(1000);
        }
        public static void WaitThreadForLongTime()
        {
            Thread.Sleep(3000);
        }

        public static async Task WaitTaskForSmallTime()
        {
            await Task.Delay(1000);
        }

        public static async Task WaitTaskForLongTime()
        {
            await Task.Delay(3000);
        }
    }
}

  
