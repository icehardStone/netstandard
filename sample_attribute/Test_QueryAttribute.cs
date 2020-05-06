using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Linq;

namespace sample_attribute
{
    public class Test_QueryAttribute
    {
        public void Test()
        {
            var type = typeof(Query);
            MethodInfo info = type.GetMethod("QueryFromSql");
            var attrs = info.GetCustomAttributes(typeof(QueryAttribute),false) as QueryAttribute[];
            var sql = attrs.First().sql;
            
            Console.WriteLine($"sql:{sql}");
        }
    }
}