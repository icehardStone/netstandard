using System;
using CSRedis;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace sample_redis
{
    /// <summary>
    /// redis help帮助类
    /// </summary>
    public class RedisHelper
    {
        private static RedisClient client { set; get; }
        public static void Init(string connectionString)
        {
            RedisClientPool pool = new RedisClientPool(connectionString, p =>
            {
                p.Connected += P_Connected;
            });
            if (pool.IsAvailable)
            {
                var temp = pool.Get(TimeSpan.FromMinutes(1));
                client = temp.Value;
                bool isConnected = client.Connect((int)TimeSpan.FromSeconds(60).TotalSeconds);
                if (!isConnected)
                    throw new Exception("the client is can't to connected!");
            }
        }
        private static void P_Connected(object sender, EventArgs e)
        {
            var client = (RedisClient)sender;
        }
        public static List<T> GetListByKey<T>(string key, int dbCount) where T : class
        {
            return GetObjectByKey<List<T>>(key,dbCount);
        }
        public static List<T> GetListByKey<T>(string key) where T : class
        {
            return GetListByKey<T>(key, 0);
        }
        public static string GetValueByKey(string key, int dbCount)
        {
            client.Select(dbCount);
            if (client == null)
                throw new Exception("the client is null!");
            return client.Get(key);
        }
        public static string GetValueByKey(string key)
        {
            return GetValueByKey(key, 0);
        }
        public static T GetObjectByKey<T>(string key)
        {
            return GetObjectByKey<T>(key, 0);
        }
        public static T GetObjectByKey<T>(string key, int dbCount)
        {
            var temp = GetValueByKey(key, dbCount);
            return JsonConvert.DeserializeObject<T>(temp);
        }
        public static void SetValue(string key, string val)
        {
            SetValue(key, val, null, 0);
        }
        public static void SetValue(string key, string val, int db)
        {
            SetValue(key, val, null, db);
        }
        public static void SetValue(string key, string val, TimeSpan expired, int dbCount)
        {
            SetValue(key, val, (TimeSpan?)expired, dbCount);
        }
        private static void SetValue(string key, object val, TimeSpan? expired, int dbCount)
        {
            if (client == null)
                throw new Exception("the client is null!");

            if (client.IsConnected)
            {
                if (val == null)
                {
                    throw new Exception("the set value is null!");
                }
                client.Select(dbCount);
                if (expired != null)
                {
                    client.Set(key, val, (TimeSpan)expired);
                }
                else
                {
                    client.Set(key, val);
                }
            }
            else
            {
                throw new Exception("the client is disclient");
            }
        }
        public static void SetValue(string key, object val)
        {
            string temp = JsonConvert.SerializeObject(val);
            SetValue(key, temp, null, 0);
        }
        public static void SetValue(string key, object val, TimeSpan expired)
        {
            string temp = JsonConvert.SerializeObject(val);
            SetValue(key, temp, expired, 0);
        }
        public static void SetValue(string key, object val, TimeSpan expired, int dbCount)
        {
            string temp = JsonConvert.SerializeObject(val);
            SetValue(key, temp, expired, dbCount);
        }
    }
}