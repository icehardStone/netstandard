using System;
using System.Linq;

namespace sample_linq_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WhereMethod whereMethod = new WhereMethod();
            whereMethod.WhereTest();
        }
    }
}
