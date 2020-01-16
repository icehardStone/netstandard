using System;
using System.Collections.Generic;

namespace sample_xmlSerialization
{
    public class Person
    {
        public string Name{set;get;}
        public int Age{set;get;}
        public string IdNumber{set;get;}
        public List<string>  Address{set;get;}
        public List<Card>  Cards{set;get;}
    }
}