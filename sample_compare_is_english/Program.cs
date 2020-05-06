using System;

namespace sample_compare_is_english
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string content = Console.ReadLine();
                for (int i = 0; i < content.Length; i++)
                {
                    bool result = IsEnglish(content[i]);
                    Console.WriteLine(result);
                }
            }
        }

        public static bool IsEnglish(char c)
        {
            if (c < 'a' || c > 'z')
            {
                if (c >= 'A')
                {
                    return c <= 'Z';
                }
                return false;
            }
            return true;
        }
    }
}
