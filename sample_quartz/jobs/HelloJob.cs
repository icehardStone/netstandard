using System.Threading.Tasks;
using Quartz;
using Quartz.Core;
using System;

namespace sample_quartz
{
    public class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync($"{DateTime.Now}:Greeting from hello world"); 
            // throw new System.NotImplementedException();
        }
    }
}