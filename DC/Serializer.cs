using System.IO;
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

								public XmlDocument loadToXML(Wniosek document)
								{
												XmlDocument xmlDocument = new XmlDocument();
												using (MemoryStream stream = new MemoryStream())
												{
																XmlWriter writer = XmlWriter.Create(stream);
																XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
																xmlSerializer.Serialize(writer, document);

																XmlReaderSettings xrset = new XmlReaderSettings();
																xrset.ValidationType = ValidationType.Schema;
																
																stream.Position = 0;

																XmlReader reader = XmlReader.Create(stream, xrset);
																xmlDocument.Load(reader);
												}
												XmlElement root = xmlDocument.DocumentElement;
												XmlAttribute date = xmlDocument.CreateAttribute("data_zlozenia", "data_zlozenia", "");
												date.Value = document.data_zlozenia.ToShortDateString();
												root.Attributes.Append(date);

												return xmlDocument;
								}
				}
}
