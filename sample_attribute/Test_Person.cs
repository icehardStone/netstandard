using System;
using System.Linq;

namespace sample_attribute
{
    public class Test_Person
    {
        public void Test()
        {
            var type = typeof(Person);
            var methodInfos = type.GetMethods();

            foreach (var method in methodInfos)
            {
                var attrs = method.GetCustomAttributes(typeof(PersonAttribute), false) as PersonAttribute[];
                foreach (var attr in attrs)
                {
                    var info = attr.Info();
                    Console.WriteLine(info);
                }
            }
            Person p = new Person();
            var meth = methodInfos.Where(o => o.Name == "Admas").First();
            meth.Invoke(p,null);

             Console.WriteLine(meth.DeclaringType.Name);
             Console.WriteLine(meth.ReflectedType.Name);

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                var attributes = field.GetCustomAttributes(typeof(Test_Attribution), true) as Test_Attribution[];
                foreach (var attr in attributes)
                {
                    var resutl = attr.Val();
                }
            }
        }
    }
}