using System;

namespace  sample_attribute
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple=true,Inherited=true)]
    public class QueryAttribute : Attribute
    {
        public string sql{set; get;}
    }
}