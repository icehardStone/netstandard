using System;

namespace sample_task_runs
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskRunTest taskRunTest = new TaskRunTest();
            taskRunTest.CancellationTokenTest();
        }
    }
}
