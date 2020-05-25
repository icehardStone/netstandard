using System;

namespace sample_attribute
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple=true,Inherited=true)]
    public class PersonAttribute : Attribute
    {
        public string name {set;get;}
        public int age {set;get;}
        public bool gender {set;get;}
        public PersonAttribute(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string Info()
        {
            return $"{this.name}-{this.age}-{this.gender}";
        }
    }
}