using System;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Threading;
namespace sample_memorystroge_shared
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryMappedFile mappedFile = MemoryMappedFile.CreateNew("map.data", 10000000);
            var stream = mappedFile.CreateViewStream();
            Mutex mutex = new Mutex(true,"textmutex",out bool createNow);
            
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write("this is a test string！");
                writer.Close();
                mutex.ReleaseMutex();
            }
            var temp = Console.ReadLine();
        }
    }
}
