using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace sample_task_runs
{
    public class ParallelPragram
    {
        public void Test()
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Parallel.ForEach(data, item =>
            {
                Console.WriteLine($"item[{item}] is runing");
            });

            // // 不带参数，也不返回值
            // Task.Run(() => {
            //     Console.WriteLine("1");
            // });
            // 返回值
            Task<int>.Run(() =>
            {
                return 10;
            });
            // 可以传递参数
            Action<object> action = (object item) =>
            {
                Console.WriteLine(item);
            };
            // Action<object,bool> action1 = (object item) => {
            //     return false;
            // };
            Func<object, int> func = (object item) =>
            {
                return 100;
            };
            // Action
            var task = new Task<int>(func, 100);
            task.ContinueWith(ct => {
                Console.WriteLine(ct.Result);
            });
            task.Start();
            Console.WriteLine("start......................");
            // task.Start();
        }
    }
}