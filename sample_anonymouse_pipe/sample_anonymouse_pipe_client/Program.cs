using System;
using System.IO;
using System.IO.Pipes;

namespace sample_anonymouse_pipe_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if(args.Length > 0)
            {
                using(PipeStream client =new AnonymousPipeClientStream(PipeDirection.In,args[0]))
                {
                    Console.WriteLine("[Client] Current TransmissionMode:{0}",client.TransmissionMode);
                    using(StreamReader reader = new StreamReader(client))
                    {
                        string temp;
                        do{
                            Console.WriteLine("[Client] wait for sync....");
                            temp = Console.ReadLine();
                        }while(!temp.StartsWith("SYNC"));

                        while((temp = reader.ReadLine()) != null)
                        {
                            Console.WriteLine("[Client] echo:"+temp);
                        }
                    }
                }
            }
        }
    }
}
