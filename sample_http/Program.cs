using System;
using System.Threading.Tasks;

namespace sample_http
{
    class Program
    {
        static void Main(string[] args)
        {
            // HttpClientTest clientTest = new HttpClientTest();
            // var result = clientTest.GetTest();
            // Console.WriteLine(result.Result);

            GatewayIPAddressInformationTest test = new GatewayIPAddressInformationTest();
            test.Test();
        }
    }
}
