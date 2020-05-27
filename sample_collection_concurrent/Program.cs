using System;

namespace sample_collection_concurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            // BlockCollectionTest.TryTakenTest();
            // InterlockedTest test = new InterlockedTest();
            // test.TryAdd();

            TaskTest taskTest = new TaskTest();
            // taskTest.ParallelTest();
            // taskTest.TaskTests();
            taskTest.ContinueWithTest();
        }
    }
}
