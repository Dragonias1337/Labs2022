using Lab7Library;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace Lab7
{
    internal class Program
    {
        static void MakeXML(List<Animal> container)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", String.Empty);
            xmlDoc.PrependChild(xmlDec);
            XmlElement elemRoot = xmlDoc.CreateElement("Lab7");
            xmlDoc.AppendChild(elemRoot);


            foreach (var animal in container)
            {
                Type idType = animal.GetType();
                //elemRoot.PrependChild(xmlDec);
                XmlElement rootChild = xmlDoc.CreateElement(idType.ToString());
                elemRoot.AppendChild(rootChild);
                XmlElement elem = null;
                foreach (PropertyInfo pInfo in idType.GetProperties())
                {
                    object o = pInfo.GetValue(animal, null);
                    elem = xmlDoc.CreateElement(pInfo.Name);
                    if (o != null)
                        elem.InnerText = o.ToString();
                    rootChild.AppendChild(elem);
                }
            }
            xmlDoc.Save("123.xml");

        }

        static void Main(string[] args)
        {
            var container = new List<Animal>();
            container.Add(new Cow()
            {
                Name = "Ivan",
                Country = "Russia"
            });
            container.Add(new Lion()
            {
                Name = "Magomed",
                Country = "Dag05"
            });
            container.Add(new Pig()
            {
                Name = "Mikola",
                Country = "Ukraine"
            });

            MakeXML(container);

        }

        
    }
}