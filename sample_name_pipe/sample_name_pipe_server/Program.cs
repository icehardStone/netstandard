using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Text.Encodings;
using System.Text.Unicode;

namespace sample_name_pipe_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class SteramString
    {
        private Stream ioStream;
        private UnicodeEncoding  streamEncoding;

        public SteramString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;
            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] buffer = new byte[len];

            ioStream.Read(buffer,0,len);

            return streamEncoding.GetString(buffer);
        }
    }
}
