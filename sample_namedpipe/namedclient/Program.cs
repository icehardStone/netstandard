using System;
using System.IO;
using System.IO.Pipes;

namespace namedclient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            using (NamedPipeClientStream clientStream = new NamedPipeClientStream(".", "server1", PipeDirection.In))
            {
                Console.WriteLine("Attemping to connect to pipe.....");
                clientStream.Connect();

                using (StreamReader reader = new StreamReader(clientStream))
                {
                    string temp;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("received from the server:{0}", temp);
                    }
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
            }
        }
    }
}
