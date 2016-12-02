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

								public void validateAndSaveDocument()
								{
												DocumentCreator creator = new DocumentCreator(view);
												Wniosek document = creator.Create();
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xml = serializer.loadToXML(document);

												Validator validator = new Validator();
												bool isCorrect = validator.Validate(xml);

												if (isCorrect)
												{
																if (saveXML(xml, document))
																{
																				System.Windows.Forms.MessageBox.Show("Zapisano");
																}
												};
								}

								private bool saveXML(XmlDocument xml, Wniosek document)
								{
												if (view.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
												{
																xml.Save(view.SaveFileDialog.FileName);
																return true;
												}
												return false;
								}
				}

				
}
