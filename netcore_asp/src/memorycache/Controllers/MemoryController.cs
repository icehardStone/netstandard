using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;

namespace memorycache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemorycacheController : Controller
    {
        private IMemoryCache cache { set; get; }
        public MemorycacheController(IMemoryCache memoryCache)
        {
            this.cache = memoryCache;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <returns></returns>
        public IList<string> QueryResult()
        {
            string key = "key";
            string value = "value";

            // 直接设置 key/value
            cache.Set(key,value);

            // MemoryCacheEntryOptions 
            MemoryCacheEntryOptions options = new MemoryCacheEntryOptions();
            options.Priority = CacheItemPriority.Low;
            options.SetAbsoluteExpiration(DateTime.UtcNow.AddHours(1));
            cache.Set(key,value,options);

            // DateTimeOffSet
            cache.Set(key,value,DateTimeOffset.Now.AddHours(1));
            // DateTimeSapn
            cache.Set(key,value,TimeSpan.FromSeconds(20));

            //
            //cache.Set(key,value,ChangeToken. )

            return new List<string>();
        }

    }
}