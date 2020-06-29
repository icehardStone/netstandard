using System;
using System.Threading;
using System.Threading.Tasks;

namespace sample_task_runs
{
    public class TaskRunTest
    {
        public void Test()
        {
            Action action1 = () =>
            {
                Console.WriteLine("test 1");
            };
            var task1 = Task.Run(action1);

            Func<string> func1 = () =>
            {
                return "func1";
            };
            var task2 = Task.Run(func1);
            Console.WriteLine(task2.Result);

            task2.ContinueWith(ins =>
            {
                Console.WriteLine(ins.Result);
            });

            Task.WaitAll();
        }
        /// <summary>
        /// CancellationToken Task
        /// </summary>
        public void CancellationTokenTest()
        {
            // Taken 是一个令牌。当我们对Token 执行Cancel 操作时，所有的宿主线程或者任务都会收到取消通知，
            // 然后做出让线程或者任务终止执行的操作

            CancellationTokenSource source = new CancellationTokenSource();
            var taken = source.Token;
            int temp = 0;

            Task.Run(() => {
                while(true)
                {
                    Console.WriteLine("threding 1 is doing!");
                    // Thread.Sleep()
                }
            },taken);
            while(temp <= 7)
            {
                Console.WriteLine("......");
                Thread.Sleep(100);
            }
            source.Cancel();
            //taken.IsCancellationRequested = true;
        }
    }
}