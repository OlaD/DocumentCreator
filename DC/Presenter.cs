using System.Xml;

namespace DC
{
				class Presenter
				{
								MainWindow view;

								public Presenter(MainWindow view)
								{
												this.view = view;
								}

								// test:
								// pola w view będą miały odpowiednie wartości
								public void loadDataToFields(string path)
								{
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												Wniosek document = SerializeDocument(path, serializer);
												XmlDocument xmlDocument = loadDataFromXML(serializer, document);
												bool isCorrect = validateData(xmlDocument);
												if (isCorrect)
												{
																FormFiller filler = new FormFiller(view);
																filler.FillFields(document);
												};
								}

								// test:
								// obiekt będzie miał odpowiednie wartości
								private Wniosek SerializeDocument(string path, Serializer<Wniosek> serializer)
								{	
												Wniosek document = serializer.loadFromXML(path);
												return document;
								}

								// test:
								// dokument będzie miał odpowiednie wartości
								private XmlDocument loadDataFromXML(Serializer<Wniosek> serializer, Wniosek document)
								{

												XmlDocument xmlDocument = serializer.loadToXML(document);
												return xmlDocument;
								}

								// test:
								// poprawny dokument zwróci true
								// zły zwróci false
								private bool validateData(XmlDocument xmlDocument)
								{
												Validator validator = new Validator();
												bool isCorrect = validator.ValidateAll(xmlDocument, false);
												return isCorrect;
								}
				}

				
}
