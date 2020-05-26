using System;

namespace sample_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //ActivityTest test = new ActivityTest();
            //test.Test();

            StopWatchTest test = new StopWatchTest();
            test.Test();

            var result = CmdHelper.RunCmd("dir");
            Console.WriteLine(result);
        }
    }
}
