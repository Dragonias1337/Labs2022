using Lab7Library;
using System.Reflection;
using System.Xml;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow c1 = new Lab7Library.Cow()
            {Name = "Ivan",
            Country = "Russia"};

            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", String.Empty);
            Type idType = c1.GetType();
            xmlDoc.PrependChild(xmlDec);
            XmlElement elemRoot = xmlDoc.CreateElement(idType.ToString());
            xmlDoc.AppendChild(elemRoot);
            XmlElement elem = null;            
            foreach (PropertyInfo pInfo in idType.GetProperties())
            {
                object o = pInfo.GetValue(c1, null);
                elem = xmlDoc.CreateElement(pInfo.Name);
                if(o!=null)
                elem.InnerText = o.ToString();
                elemRoot.AppendChild(elem);
            }
            xmlDoc.Save("123.xml");

        }
    }
}