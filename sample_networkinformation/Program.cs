using System;

namespace sample_networkinformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PingTest test = new PingTest();
            test.Test();
        }
    }
}
