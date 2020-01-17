//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith iceharstone
// @Ttitle:    
// @DateTime:  2020-01-05 15:19
// @Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Text;

namespace Sample_MemoryStream_Test
{
    public class MemoryStream_Test
    {
        public MemoryStream_Test()
        {
            using(MemoryStream stream = new MemoryStream())
            {
                string testString = "thie is a test string!";
                byte[] bts = Encoding.UTF8.GetBytes(testString);

                stream.Write(bts,0,bts.Length);
                Console.WriteLine(stream.CanRead);
                Console.WriteLine(stream.CanWrite);
                Console.WriteLine(stream.CanSeek);
                stream.Seek(0,SeekOrigin.Begin);

                Console.WriteLine(stream.Position);
                //Console.WriteLine(stream.ReadTimeout);
                Console.WriteLine(stream.Capacity);
                //Console.WriteLine(stream.Read(new byte[1024],0,bts.Length-1));
                stream.Seek(0,SeekOrigin.Begin);
                
                stream.BeginRead(new byte[1024],0,10,new AsyncCallback(EndReader),stream);
            }          
        }
        public static void EndReader(IAsyncResult result)
        {
            MemoryStream stream = (MemoryStream)result.AsyncState;
            Console.WriteLine(stream.Capacity);
            Console.WriteLine("end");

            stream.EndRead(result);
        }
    }
}