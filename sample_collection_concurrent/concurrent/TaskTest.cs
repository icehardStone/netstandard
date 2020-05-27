using System;
using System.Threading.Tasks;
using System.Threading;

namespace sample_collection_concurrent
{
    public class TaskTest
    {
        public void ParallelTest()
        {
            Action action = () =>
            {
                Console.WriteLine("threading");
            };
            Parallel.Invoke(action, action, action);
        }
        public void TaskTests()
        {
            Action<Object> action = (obj) =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Task {obj} 's id is {Task.CurrentId}");
                // Task.Delay(5000);
            };
            Task task1 = new Task(action, "1");
            task1.Start();

            Task task2 = Task.Run(() =>
            {
                Console.WriteLine($"Task 2 's id is {Task.CurrentId}");
            });

            Task[] tasks = new Task[] { task1, task2 };
            Task.WaitAny(tasks);
            // Task.WaitAll(tasks);
            Console.WriteLine($"task is over ? {task1.IsCompleted}");
            Task.WaitAll(tasks);
        }
        public void ContinueWithTest()
        {
            var task1 = Task.Factory.StartNew(() => {
                return 1;
            });
            var result1 = task1.ContinueWith((ins) => {
                Console.WriteLine($"the result is {ins.Result}");
                return "continue";
            });
            result1.ContinueWith((ins) => {

            },new TaskContinuationOptions()
            {
                
            });
            //task1.Start();
            //Task.WaitAll();
            Console.WriteLine("over");
        }
    }
}