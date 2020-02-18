using System;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace sample_anonymouse_pipe_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Process  client = new Process();
            client.StartInfo.FileName="sample_anonymouse_pipe_client";
            using(AnonymousPipeServerStream server = new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable))
            {
                Console.WriteLine("[Server Curren TransmissionMode:{0}]",server.TransmissionMode);

                client.StartInfo.Arguments = server.GetClientHandleAsString();
                client.StartInfo.UseShellExecute = false;
                client.Start();

                server.DisposeLocalCopyOfClientHandle();

                try{
                    using(StreamWriter writer = new StreamWriter(server))
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine("SYNC");

                        server.WaitForPipeDrain();
                        Console.WriteLine("[Server] Enter text");
                        writer.WriteLine(Console.ReadLine());
                    }

                }
                catch(IOException error)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
