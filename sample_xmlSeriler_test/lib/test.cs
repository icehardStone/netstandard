using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace sample_xmlSerialization
{
    public class  test
    {
        public XmlSerializer Serializer{set;get;}
        public Person p {set;get;}
        public test()
        {
            this.Serializer = new XmlSerializer(typeof(Person));
            p = new Person();
        }
        public void run()
        {
            p.Name = "admas";
            p.Age = 12;
            p.IdNumber = "10086";
            p.Address = new System.Collections.Generic.List<string>();
            p.Address.Add("tams river");
            p.Address.Add("yeols river");
            p.Cards = new System.Collections.Generic.List<Card>();
            p.Cards.Add(new Card{
                Number = "0001",
                SignTime = DateTime.Now
            });
            p.Cards.Add(new Card{
                Number = "0002",
                SignTime = DateTime.Now
            });
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            this.Serializer.Serialize(writer,p);

            stream.Seek(0,SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}