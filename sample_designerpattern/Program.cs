using System;

namespace sample_designerpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// test 1
            /// </summary>
            /// <returns></returns>
            Single test1 = Single.CreateInstance();
            Console.WriteLine(test1.Number);
            /// <summary>
            /// test2
            /// </summary>
            /// <returns></returns>
            Single test2 = Single.CreateInstance();
            Console.WriteLine(test2.Number);

            /// <summary>
            /// the factory pattern
            /// </summary>
            /// <returns></returns>
            Factory factory = new Factory();
            var result1 = factory.CreateThings(false);
            result1.Says();
            /// <summary>
            /// the result2 things
            /// </summary>
            /// <returns></returns>
            var result2 = factory.CreateThings(true);
            result2.Says();
        }
    }
}
