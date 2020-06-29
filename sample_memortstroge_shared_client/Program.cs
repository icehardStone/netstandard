using System;
using System.Threading;
using System.IO.MemoryMappedFiles;
using System.IO;

namespace sample_memorystroge_shared_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = Mutex.OpenExisting("textmutex");
            mutex.WaitOne();
            using(var stream = MemoryMappedFile.CreateOrOpen("map.data",10000000).CreateViewStream())
            {
                BinaryReader reader = new BinaryReader(stream);
                Console.WriteLine(reader.ReadString());
            }
            mutex.ReleaseMutex();
        }
    }
}
