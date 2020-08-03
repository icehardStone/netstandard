using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Threading.Channels;

namespace sample_threading_channel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 限制了访问同一个线程的数量
            Semaphore semaphore = new Semaphore(3,5,"sem");
            // SemaphoreSlim semaphore = new SemaphoreSlim()
            semaphore.WaitOne();
            Console.WriteLine($"this is semaphore start");
            Console.ReadLine();
            semaphore.Release();
            Console.WriteLine($"this is semaphore end");
            // Console.WriteLine("Hello World!");

            // Channel<string> channel = Channel.CreateBounded<string>(10);

            // var write = channel.Writer;
            // var rader = channel.Reader;

            // while()
        }
    }
}
