using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DC
{
				public class Serializer<T>
				{
								public T loadFromXML(string xmlPath)
								{
												T document;
												XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
												using (FileStream fileStream = new FileStream(xmlPath, FileMode.Open))
												{
																XmlReader reader = XmlReader.Create(fileStream);
																document = (T)xmlSerializer.Deserialize(reader);
												}
												return document;
								}

								public void saveToXML(T document)
								{

								}
				}
}
