using Microsoft.VisualStudio.TestTools.UnitTesting;
using DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.Tests
{
				[TestClass()]
				public class SerializerTests
				{
								[TestMethod()]
								public void loadFromXmlTest()
								{
												Serializer<Wniosek> target = new Serializer<Wniosek>();
												string path = @"wniosekJanKowalski.xml";
												string expectedName = "Jan";
												string actualName = target.loadFromXML(path).kandydat.dane_kandydata.imie;
												Assert.AreEqual(expectedName, actualName);
								}
				}
}