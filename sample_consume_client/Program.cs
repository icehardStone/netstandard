using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.IO;
using System.Text;

namespace sample_consume_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "192.168.43.8",
                UserName="admin",
                Password = "admin",
                RequestedChannelMax = 2000,
                RequestedConnectionTimeout = TimeSpan.FromSeconds(200),
                RequestedHeartbeat = TimeSpan.FromMilliseconds(500)
            };
            using(var connection = connectionFactory.CreateConnection())
            {
                using(var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("testQueue",true,false,false,null);
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received +=    (model,er) => 
                    {
                        Console.WriteLine(model.GetType().Name);
                        Console.WriteLine(er);
                        using(MemoryStream stream = new MemoryStream(er.Body.ToArray()))
                        {
                            using(TextReader reader = new StreamReader(stream))
                            {
                                Console.WriteLine(reader.ReadToEnd());
                            }      
                        }
                    };
                    channel.BasicConsume("testQueue",true,consumer:consumer);
                    Console.ReadLine();
                }
            }
        }
    }
}
