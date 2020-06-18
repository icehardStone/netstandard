using System;
using RabbitMQ.Client;
using System.Timers;

namespace sample_rabbitmq_client
{
    class Program
    {
        public static IConnection _connection { set; get; }
        static void Main(string[] args)
        {
            _connection = CreateChannel();

            Timer timer = new Timer(1000);
            timer.Elapsed += TimerMethods;
            timer.AutoReset = true;
            timer.Enabled = true;

            timer.Start();
            Console.Read();
        }
        public static IConnection CreateChannel()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "192.168.43.8",
                UserName = "admin",
                Password = "admin",
                RequestedChannelMax = 2000,
                RequestedConnectionTimeout = TimeSpan.FromSeconds(100),
                RequestedHeartbeat = TimeSpan.FromMilliseconds(500)
            };
            /// <summary>
            /// 创建连接
            /// </summary>
            /// <returns></returns>
            var connection = connectionFactory.CreateConnection();
            return connection;
        }
        /// <summary>
        /// 使用定时器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TimerMethods(object sender, System.Timers.ElapsedEventArgs e)
        {
            using (var channel = _connection.CreateModel())
            {
                channel.QueueDeclare("testQueue", true, false, false, null);
                string body = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                Console.WriteLine(body);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(body);
                channel.BasicPublish(exchange: "", routingKey: "testQueue", null, bytes);
            }
        }
    }
}
