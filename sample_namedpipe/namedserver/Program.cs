using System;
using System.IO.Pipes;
using System.IO;

namespace namedserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (NamedPipeServerStream serverStream = new NamedPipeServerStream("server1", PipeDirection.Out))
            {
                while (true)
                {
                    serverStream.WaitForConnection();
                    if (serverStream.IsConnected)
                    {
                        ProcessStream(serverStream);
                    }
                }
            }
        }
        public static void ProcessStream(Stream stream)
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                Console.WriteLine("Please input:");
                string temp = Console.ReadLine();
                Console.WriteLine("Input String is {0}", temp);
                writer.WriteLine(temp);
            }
        }
    }
}
