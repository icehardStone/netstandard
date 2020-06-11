using System;
using System.Net.NetworkInformation;

namespace sample_http
{
    public class GatewayIPAddressInformationTest
    {
        public void Test()
        {
            /// <summary>
            /// ICMPv4 统计数据
            /// </summary>
            /// <returns></returns>
            IPGlobalProperties  properties = IPGlobalProperties.GetIPGlobalProperties();

            IcmpV4Statistics stat = properties.GetIcmpV4Statistics();

            Console.WriteLine("HostName:{0}",properties.HostName);
            Console.WriteLine("DomainName:{0}",properties.DomainName);
            Console.WriteLine("DhcpScopeName:{0}",properties.DhcpScopeName);

        }
    }
}