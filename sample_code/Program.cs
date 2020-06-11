using System;
using System.Text.Encodings;
using System.Text;

namespace sample_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Base64 Code

            string temp = "test code";
            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(temp));
            Console.WriteLine("base64 string:{0}",base64String);
        }
    }
}
