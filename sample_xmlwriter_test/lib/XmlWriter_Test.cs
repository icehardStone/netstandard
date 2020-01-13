using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text;
using System;

namespace sample_xmlwriter_test
{
    public class XmlWriter_Test
    {
        public XmlWriter_Test()
        {

        }
        public void Write()
        {
            MemoryStream stream = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            //settings.OmitXmlDeclaration = true;
            settings.Encoding = UTF8Encoding.Default;
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                writer.WriteStartElement(null, "div", null);
                writer.WriteStartElement("span");
                writer.WriteString("stream");
                //writer.WriteAttributeString(null,"id",null,"10089");
                //writer.WriteAttributeString("ISBN", "urn:book", "1-800-925");
                writer.WriteComment("comment");
                writer.WriteCData("cdata");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("使用流");
        }
    }
}