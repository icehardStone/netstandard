using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace sample_http
{
    public class HttpClientTest
    {
        public HttpClientHandler httpClientHandler;
        public HttpClient client {set;get;}
        public HttpClientTest ()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://www.baidu.com");
        }
        public async Task<string> GetTest()
        {
            var httpMessageResponse = await client.GetAsync("/");
            return await httpMessageResponse.Content.ReadAsStringAsync();
        }
    }
}