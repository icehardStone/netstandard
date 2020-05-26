using System;
using System.Diagnostics;
using System.Threading;

namespace sample_activity
{
    public class StopWatchTest
    {
        public void Test()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Thread.Sleep(1000);
            watch.Stop();

            TimeSpan span = watch.Elapsed;
            Console.WriteLine(span.TotalMilliseconds);
            Console.WriteLine(span.Seconds);
        }
    }
}