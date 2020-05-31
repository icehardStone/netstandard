using System;

namespace sample_event
{
    class Program
    {
        static void Main(string[] args)
        {
            EventTest test = new EventTest();
            test.ThrowHolder +=  OnThrowHolder2;
            test.Add(10);
            // Console.WriteLine("Hello World!");
        }
        public static void OnThrowHolder2(object obj, EventArgs e)
        {
            Console.WriteLine("event two!");
        }
    }
}
