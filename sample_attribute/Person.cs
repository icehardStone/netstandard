using System;

namespace sample_attribute
{
    public class Person
    {
        [PersonAttribute("admas",12,true)]
        public void Admas(){}

        [PersonAttribute("tomas",20,false)]
        public void Tomas(){}
    }
}