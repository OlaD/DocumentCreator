using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DC
{
				static class DocumentCreator2
				{
								static Wniosek document;

								public static void Create()
								{
												document = new Wniosek();
												document.kandydat = new Kandydat();
												document.kandydat.dane_kandydata = new Dane();
												document.kandydat.ukonczona_uczelnia = new Uczelnia();
												document.kandydat.uzyskane_tytuly = new Tytuly();
												document.zatrudnienie = new Zatrudnienie();
												document.zatrudnienie.czas_zatrudnienia = new Czas_Zatrudnienia();
								}

								public static void SetName(string name)
								{
												//CreateDocumentIfNotExist();
												//CreateCandidatIfNosExist();
												//CreateCandidatDataIfNotExist();
												document.kandydat.dane_kandydata.imie = name;

												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xmlDocument = serializer.loadToXML(document);
												Validator validator = new Validator();
												//validator.ValidNode(Fields.Field.name, xmlDocument);
								}

								private static void CreateDocumentIfNotExist()
								{
												if(document == null)
												{
																document = new Wniosek();
												}
								}

								private static void CreateCandidatIfNosExist()
								{
												if (document.kandydat == null)
												{
																document.kandydat = new Kandydat();
												}
								}

								private static void CreateCandidatDataIfNotExist()
								{
												if (document.kandydat.dane_kandydata == null)
												{
																document.kandydat.dane_kandydata = new Dane();
												}
								}

				}
}
