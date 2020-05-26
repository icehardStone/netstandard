using System;
using System.IO;
using System.IO.Compression;

namespace sample_compress
{
    public class BrotliStreamTest
    {
        public void Comprocess()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write("this is a test stream");
            BrotliStream stream1 = new BrotliStream(stream,CompressionLevel.Fastest);
        }
    }
}