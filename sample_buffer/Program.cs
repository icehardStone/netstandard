using System;
using System.Buffers;

namespace sample_buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayPool<Person> pool = ArrayPool<Person>.Shared;
            Person[] temp =  pool.Rent(10);
        }
    }
    public class Person
    {
        public string ID{set;get;}
        public string Name{set;get;}
    }
}
