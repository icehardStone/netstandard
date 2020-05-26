using System;
using System.Diagnostics;

namespace sample_activity
{
    public class ActivityTest
    {
        public void Test()
        {
            Activity test = Activity.Current;

            Console.WriteLine(test.ActivityTraceFlags);
            Console.WriteLine(test.Baggage);
            Console.WriteLine(test.Duration);
            Console.WriteLine(test.Id);
            Console.WriteLine(test.IdFormat);
            Console.WriteLine(test.ParentId);
            Console.WriteLine(test.StartTimeUtc);
            foreach(var temp in test.Tags)
            {
                Console.WriteLine(temp.Key+":"+temp.Value);
            }
        }
    }
}