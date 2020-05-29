using System;
using System.Net.NetworkInformation;
using System.Net;
using System.ComponentModel;

namespace sample_networkinformation
{
    public class PingTest
    {
        public void Test()
        {
            Ping ping = new Ping();
            var  reply =  ping.Send("www.baidu.com");
            Console.WriteLine("Address\t\t\t\t:{0}",reply.Address.ToString());
            Console.WriteLine("RoundTrip time\t\t\t:{0}",reply.RoundtripTime);
            Console.WriteLine("Time to live\t\t\t:{0}",reply.Options.Ttl);
            Console.WriteLine("Don't fragment to live\t\t:{0}",reply.Options.DontFragment);
            Console.WriteLine("Buffer size\t\t\t:{0}",reply.Buffer.Length);
        }
    }
}