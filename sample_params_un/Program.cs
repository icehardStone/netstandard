using System;

namespace sample_params_un
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("1","2","3","4");
            Test("admas","tomas");
            Console.WriteLine("test array!");
        }
        public static void Test(params string[] strs)
        {
            Console.WriteLine(strs);
            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
