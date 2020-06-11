using System;

namespace sample_attribute
{
    public class Person
    {
        [PersonAttribute("admas",12,true)]
        public void Admas()
        {
            Console.WriteLine("admas");
        }

        [PersonAttribute("tomas",20,false)]
        public void Tomas(){}

        [Test_Attribution("admas","true")]
        public string Name;
    }
}