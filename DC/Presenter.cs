using System.Xml;

namespace DC
{
				class Presenter
				{
								MainWindow view;
								Wniosek document;

								public Presenter(MainWindow view)
								{
												this.view = view;
								}

								// test:
								// pola w view będą miały odpowiednie wartości
								public void LoadDataToFields(string path)
								{
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												document = SerializeDocument(path, serializer);
												XmlDocument xmlDocument = LoadDataToXML(serializer, document);
												bool isCorrect = ValidateData(xmlDocument);
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
								private XmlDocument LoadDataToXML(Serializer<Wniosek> serializer, Wniosek document)
								{
												XmlDocument xmlDocument = serializer.loadToXML(document);
												return xmlDocument;
								}

								// test:
								// poprawny dokument zwróci true
								// zły zwróci false
								private bool ValidateData(XmlDocument xmlDocument)
								{
												Validator validator = new Validator();
												bool isCorrect = validator.ValidateAll(xmlDocument, false);
												return isCorrect;
								}

								public void ValidateAndSaveDocument()
								{
												DocumentCreator creator = new DocumentCreator(view);
												Wniosek document = creator.Create();
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xml = serializer.loadToXML(document);

												Validator validator = new Validator();
												bool isCorrect = validator.Validate(xml);

												if (isCorrect)
												{
																if (SaveXML(xml, document))
																{
																				System.Windows.Forms.MessageBox.Show("Zapisano");
																}
												};
								}

								private bool SaveXML(XmlDocument xml, Wniosek document)
								{
												if (view.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
												{
																xml.Save(view.SaveFileDialog.FileName);
																return true;
												}
												return false;
								}

								public string GetCity()
								{
												ParserHTML parser = new ParserHTML();
												string city = parser.GetCity(view.PostCode);
												//view.City = city;
												return city;
								}

								public void GeneratePDF()
								{
												DocumentCreator creator = new DocumentCreator(view);
												Wniosek document = creator.Create();
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xml = serializer.loadToXML(document);

												Validator validator = new Validator();
												bool isCorrect = validator.Validate(xml);

												if (isCorrect)
												{
																//if (view.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
																{
																				PDFGenerator generator = new PDFGenerator(document);
																				//generator.GeneratePDF(view.SaveFileDialog.FileName);
																				generator.GeneratePDF("tmp.pdf");
																}
												};
								}

								public string ValidateField(Fields.Field field)
								{
												DocumentCreator creator = new DocumentCreator(view);
												Wniosek document = creator.Create();
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xml = serializer.loadToXML(document);

												Validator validator = new Validator();
												string message = validator.ValidNode(field, xml);
												return message;
								}

								public void CleanWindow()
								{
												view.Date = System.DateTime.Today;
												view.OrganizationalUnit = "";
												view.CandidatName = "";
												view.CandidatSurname = "";
												view.PostCode = "";
												view.City = "";
												view.Street = "";
												view.HouseNumber = "";
												view.FlatNumber = "";
												view.AcademyName = "";
												view.FacultyName = "";
												view.Titles.Clear();
												view.ExJobs.Clear();
												view.Achievements.Clear();
												view.Position = "";
												view.StartDate = System.DateTime.Today;
												view.IsDefiniteWorkTime = true;
												view.EndDate = System.DateTime.Today;
												view.IsFullWorkTime = true;
												view.IsContract = true;
								}
				}
}
