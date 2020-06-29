using System;
using System.Collections.Specialized;
using Quartz;
using Quartz.Core;
using Quartz.Impl;
using System.Threading.Tasks;
using Quartz.Logging;
using Quartz.Impl.Matchers;

namespace sample_quartz
{
    class Program
    {
        static void Main(string[] args)
        {

            LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());
            RunProgram().GetAwaiter().GetResult();

            // Console.WriteLine("Press any key to close the application");
            // Console.ReadKey();
            string val = Console.In.ReadLine();

            // please input a key to quit this program
            // Console.WriteLine("please input for  quit!");
            // var input = Console.Read();
        }
        public static async Task RunProgram()
        {
            try
            {
                NameValueCollection collection = new NameValueCollection()
                {
                    { "quartz.serializer.type", "binary" }
                };

                StdSchedulerFactory factory = new StdSchedulerFactory(collection);
                var schedule = await factory.GetScheduler();

                IJobDetail helloJob = JobBuilder.Create<HelloJob>()
                    .WithIdentity("helloJob", "group1")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithCronSchedule("2/1 * * * * ? ")
                    // .ForJob(new JobKey())
                    // .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(0,1))
                    // .WithSchedule(CronScheduleBuilder.)
                    .Build();

                await schedule.ScheduleJob(helloJob, trigger);
                TriggerListener myTrigger = new TriggerListener();
                // schedule.ListenerManager.AddTriggerListener(myTrigger,KeyMatcher<JobKey>.KeyEquals(new JobKey("helloJob", "group1"))
                schedule.ListenerManager.AddTriggerListener(myTrigger, KeyMatcher<TriggerKey>.KeyEquals(new TriggerKey("trigger1", "group1")));


                await schedule.Start();
                //await Task.Delay(TimeSpan.FromSeconds(60));
                var jobdetail = await schedule.GetJobDetail(new JobKey("helloJob"));
                // await schedule.Shutdown();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
