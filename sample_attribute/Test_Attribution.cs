using System;

namespace sample_attribute
{
    [AttributeUsage(AttributeTargets.Field,AllowMultiple =true,Inherited=true)]
    public class Test_Attribution :Attribute
    {
        public Test_Attribution(string name,string isbool)
        {
            Name = name;
            IsBool = isbool;
        }
        public string Name {set;get;}
        public string IsBool {set;get;}

        public string Val()
        {
            return string.Concat(Name,IsBool);
        }
    }
}