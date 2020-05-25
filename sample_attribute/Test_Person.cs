using System;

namespace    sample_attribute
{
    public class Test_Person
    {
        public void Test()
        {
            var type = typeof(Person);
            var methodInfos = type.GetMethods();

            foreach(var method in methodInfos)
            {
                var attrs = method.GetCustomAttributes(typeof(PersonAttribute),false) as PersonAttribute[];
                foreach(var attr in attrs)
                {
                    var info = attr.Info();
                    Console.WriteLine(info);
                }
            }
        }
    }
}