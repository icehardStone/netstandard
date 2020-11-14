using System;
using CSRedis;
using System.Collections.Generic;

namespace sample_redis
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectString = "192.168.43.34:60010,password=1,poolsize=10";
            RedisHelper.Init(connectString);

            RedisHelper.SetValue("DIC.USER.TYPE","doctor");
            RedisHelper.SetValue("DIC.CLSSIFY.TYPE","doctor",1);

            List<(string name,int age)> data = new List<(string name, int age)>()
            {
                ("a",10)
            };
            RedisHelper.SetValue("DIC.TEST.VAL",data);
            var temp = RedisHelper.GetObjectByKey<List<(string name,int age)>>("DIC.TEST.VAL");
            RedisHelper.SetValue("DIC.EXPIRED","expired",TimeSpan.FromSeconds(10),0);
            RedisHelper.SetValue("DIC.EXPIRED","expired",TimeSpan.FromSeconds(10),10);
        }
    }
}
