using System;

namespace sample_filesystemwatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            File_System_Watcher test = new File_System_Watcher(Environment.CurrentDirectory);
            Console.WriteLine("Hello World!");
        }
    }
}
