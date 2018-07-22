using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using System;
using System.Text;

namespace DC
{
				class PDFGenerator
				{
								const int FONT_SIZE = 12;
								const int SMALL_FONT_SIZE = 8;
								const int BIG_FONT_SIZE = 18;

								const string FONT_PATH = "times.ttf";
								const string BIG_FONT_PATH = "timesbd.ttf";

								Document document;
								Font font;
								Font smallFont;
								Font bigFont;
								Wniosek documentObject;

								public PDFGenerator(Wniosek documentObject)
								{
												this.documentObject = documentObject;
								}

								public void GeneratePDF(string path)
								{
												document = CreateDocument(path);
												document.Open();
												CreateFonts();
												WriteAll();
												document.Close();

												MessageBox.Show("Wygenerowano plik PDF");
								}

								private Document CreateDocument(string path)
								{
												Document newDocument = new Document(PageSize.A4, 100, 100, 50, 50);
												FileStream file = new FileStream(path, FileMode.Create);
												PdfWriter writer = PdfWriter.GetInstance(newDocument, file);
												return newDocument;
								}

								private void CreateFonts()
								{
												font = CreateFont(FONT_SIZE, FONT_PATH);
												smallFont = CreateFont(SMALL_FONT_SIZE, FONT_PATH);
												bigFont = CreateFont(BIG_FONT_SIZE, BIG_FONT_PATH);
								}

								private Font CreateFont(int size, string path)
								{
												BaseFont bf = BaseFont.CreateFont(path, BaseFont.CP1250, BaseFont.EMBEDDED);
												Font newFont = new Font(bf, size);
												return newFont;
								}

								private void WriteAll()
								{
												WriteOrganisationUnit();
												WriteHeader();
												WriteApplication();
												WriteTitles();
												WriteJobs();
												WriteAchievements();
												WriteFooter();
								}

								private void WriteOrganisationUnit()
								{
												string organisationUnit = documentObject.jednostka_organizacyjna;
												Paragraph paragraph = new Paragraph(organisationUnit, font);
												document.Add(paragraph);
								}

								private void WriteHeader()
								{
												Chunk top = new Chunk("Wniosek", bigFont);
												Chunk middle = new Chunk("w sprawie zatrudnienia nauczyciela akademickiego", bigFont);
												Chunk bottom = new Chunk("w Politechnice Gdańskiej", bigFont);

												Paragraph header = new Paragraph();
												header.Add(top);
												header.Add(Chunk.NEWLINE);
												header.Add(middle);
												header.Add(Chunk.NEWLINE);
												header.Add(bottom);

												header.Alignment = Element.ALIGN_CENTER;
												header.Leading = 20;
												header.SpacingBefore = 20;
												header.SpacingAfter = 40;
												document.Add(header);
								}

								private void WriteApplication()
								{
												string applicationText = BuildApplicationText();
												string livingText = BuildLivingText();
												string positionText = BuildPositionText();
												string startDateText = BuildStartDateText();
												string forPeriodText = BuildForPeriodText();
												string workingTimeText = BuildWorkingTimeText();
												string jobBaseText = BuildEmployBaseText();

												Chunk application = new Chunk(applicationText, font);
												Chunk living = new Chunk(livingText, font);
												Chunk position = new Chunk(positionText, font);
												Chunk startDate = new Chunk(startDateText, font);
												Chunk forPeriod = new Chunk(forPeriodText, font);
												Chunk workingTime = new Chunk(workingTimeText, font);
												Chunk jobBase = new Chunk(jobBaseText, font);

												Paragraph applicationParagraph = new Paragraph();
												applicationParagraph.Add(application);
												applicationParagraph.Add(Chunk.NEWLINE);
												applicationParagraph.Add(living);
												applicationParagraph.Add(Chunk.NEWLINE);
												applicationParagraph.Add(position);
												applicationParagraph.Add(startDate);
												applicationParagraph.Add(Chunk.NEWLINE);
												applicationParagraph.Add(forPeriod);
												applicationParagraph.Add(Chunk.NEWLINE);
												applicationParagraph.Add(workingTime);
												applicationParagraph.Add(jobBase);
												
												//applicationParagraph.Alignment = Element.ALIGN_JUSTIFIED_ALL;

												document.Add(applicationParagraph);
								}

								private string BuildApplicationText()
								{
												StringBuilder text = new StringBuilder();
												text.Append("Wnoszę o zatrudnienie Pana /i/ ");
												text.Append(documentObject.kandydat.dane_kandydata.imie);
												text.Append(" ");
												text.Append(documentObject.kandydat.dane_kandydata.nazwisko);
												return text.ToString();
								}

								private string BuildLivingText()
								{
												Adres address = documentObject.kandydat.dane_kandydata.adres;
												StringBuilder text = new StringBuilder();
												text.Append("zamieszkałego /łej/ w ");
												text.Append(address.miejscowosc);
												text.Append(", ");
												if(address.ulica != "")
												{
																text.Append("ul. ");
																text.Append(address.ulica);
																text.Append(" ");
												}
												text.Append(address.nr_domu);
												if(address.nr_mieszkania != null)
												{
																text.Append(" m. ");
																text.Append(address.nr_mieszkania);
												}
												text.Append(", ");
												text.Append(address.kod_pocztowy);
												return text.ToString();
								}

								private string BuildPositionText()
								{
												StringBuilder text = new StringBuilder();
												text.Append("na stanowisku ");
												text.Append(documentObject.zatrudnienie.stanowisko);
												text.Append(" ");
												return text.ToString();
								}

								private string BuildStartDateText()
								{
												StringBuilder text = new StringBuilder();
												text.Append("od dnia ");
												text.Append(BuildDate(documentObject.zatrudnienie.od_dnia));
												return text.ToString();
								}

								private string BuildDate(DateTime date)
								{
												StringBuilder text = new StringBuilder();
												text.Append(date.Day);
												text.Append(".");
												string month = date.Month.ToString();
												if (month.Length == 1)
												{
																month = "0" + month;
												}
												text.Append(month);
												text.Append(".");
												text.Append(date.Year);
												text.Append(" r.");
												return text.ToString();
								}

								private string BuildForPeriodText()
								{
												Zatrudnienie employment = documentObject.zatrudnienie;
												StringBuilder text = new StringBuilder();
												text.Append("na czas ");
												if(employment.czas_zatrudnienia.okreslony)
												{
																text.Append("określony do dnia ");
																text.Append(BuildDate(employment.czas_zatrudnienia.do_dnia));
												}
												else
												{
																text.Append("nieokreślony");
												}
												return text.ToString();
								}

								private string BuildWorkingTimeText()
								{
												//	"w wymiarze " + "pełnego " + "etatu ";
												StringBuilder text = new StringBuilder();
												text.Append("w wymiarze ");
												if (documentObject.zatrudnienie.wymiar_etatu == "pelny")
												{
																text.Append("pełnego");
												}
												else
												{
																text.Append(documentObject.zatrudnienie.wymiar_etatu);
												}
												text.Append(" etatu ");
												return text.ToString();
								}
				
								private string BuildEmployBaseText()
								{
												StringBuilder text = new StringBuilder();
												text.Append("na podstawie ");
												if(documentObject.zatrudnienie.podstawa == "mianowanie")
												{
																text.Append("mianowania.");
												}
												else
												{
																text.Append("umowy o pracę.");
												}
												return text.ToString();
								}				

								private void WriteTitles()
								{
												string academyText = BuildAcademyText();
												Chunk academy = new Chunk(academyText, font);

												string masterDegreeText = BuildMasterDegreeText();
												Chunk masterDegree = new Chunk(masterDegreeText, font);

												string doctorDegreeText = BuildDoctorDegreeText();
												Chunk doctorDegree = new Chunk(doctorDegreeText, font);

												string profDegreeText = BuildProfessorDegreeText();
												Chunk profDegree = new Chunk(profDegreeText, font);

												Paragraph titles = new Paragraph();
												titles.Add(academy);
												titles.Add(Chunk.NEWLINE);
												titles.Add(masterDegree);
												titles.Add(Chunk.NEWLINE);
												titles.Add(doctorDegree);
												titles.Add(Chunk.NEWLINE);
												titles.Add(profDegree);

												titles.SpacingBefore = 20;

												document.Add(titles);
								}

								private string BuildAcademyText()
								{
												Uczelnia academy = documentObject.kandydat.ukonczona_uczelnia;
												StringBuilder text = new StringBuilder();
												text.Append("Pan /i/ jest absolwentem /ką/ ");
												text.Append(academy.nazwa_uczelni);
												text.Append(", ");
												text.Append(academy.nazwa_wydzialu);
												return text.ToString();
								}

								private string BuildMasterDegreeText()
								{
												Tytuly titles = documentObject.kandydat.uzyskane_tytuly;
												StringBuilder text = new StringBuilder();
												text.Append("a) uzyskał /a/ tytuł zawodowy ");
												if (titles.tytul_zawodowy != null)
												{
																text.Append(titles.tytul_zawodowy.jaki.Replace('z', 'ż'));			// mgr inz. -> mgr inż.
																text.Append(" (");
																text.Append(titles.tytul_zawodowy.data_uzyskania);
																text.Append(" r.)");
												}
												else
												{
																text.Append("-");
												}

												return text.ToString();
								}

								private string BuildDoctorDegreeText()
								{
												Tytuly titles = documentObject.kandydat.uzyskane_tytuly;
												Tytul_Naukowy title = titles.tytul_naukowy;

												StringBuilder text = new StringBuilder();
												text.Append("b) uzyskał /a/ stopnie naukowe ");
												if (titles.stopien_naukowy != null)
												{
																foreach (Stopien_Naukowy degree in titles.stopien_naukowy)
																{
																				text.Append(degree.jaki);
																				text.Append(" (");
																				text.Append(degree.data_uzyskania);
																				text.Append(" r.), ");
																}
																int l = ", ".Length;
																text.Remove(text.Length - l, l);
												}
												else
												{
																text.Append("-");
												}

												return text.ToString();
								}

								private string BuildProfessorDegreeText()
								{
												Tytuly titles = documentObject.kandydat.uzyskane_tytuly;
												StringBuilder text = new StringBuilder();
												text.Append("c) uzyskał /a/ tytuł naukowy ");
												if (titles.tytul_naukowy != null)
												{
																text.Append("prof.");
																text.Append(" (");
																text.Append(titles.tytul_naukowy.data_uzyskania);
																text.Append(" r.)");
												}
												else
												{
																text.Append("-");
												}
												return text.ToString();
								}

								private void WriteJobs()
								{
												Paragraph jobsParagraph = new Paragraph();

												Chunk jobHeader = new Chunk("1. Dotychczasowy przebieg pracy:", font);
												jobsParagraph.Add(jobHeader);
												jobsParagraph.Add(Chunk.NEWLINE);

												Praca[] jobs = documentObject.kandydat.przebieg_pracy;
												if (jobs != null)
												{
																foreach (Praca job in jobs)
																{
																				string jobText = BuildJobText(job);
																				Chunk jobLine = new Chunk(jobText, font);
																				jobsParagraph.Add(jobLine);
																				jobsParagraph.Add(Chunk.NEWLINE);
																}
												}
												else
												{
																jobsParagraph.Add(new Chunk(" - ", font));
																jobsParagraph.Add(Chunk.NEWLINE);
												}

												jobsParagraph.SpacingBefore = 20;

												document.Add(jobsParagraph);
								}

								private string BuildJobText(Praca job)
								{
												StringBuilder text = new StringBuilder();
												text.Append(" od ");
												text.Append(job.rok_rozpoczecia);
												text.Append(" r. ");
												text.Append("do ");
												text.Append(job.rok_zakonczenia);
												text.Append(" r. ");
												text.Append("w ");
												text.Append(job.miejsce);
												text.Append(" stanowisko ");
												text.Append(job.stanowisko);
												return text.ToString();
								}

								private void WriteAchievements()
								{
												Paragraph achievementsParagraph = new Paragraph();

												Chunk achievementsHeader = new Chunk("2. Osiągnięcia naukowe, dydaktyczne i organizacyjne kandydata", font);
												achievementsParagraph.Add(achievementsHeader);
												achievementsParagraph.Add(Chunk.NEWLINE);

												string[] achievements = documentObject.kandydat.osiagniecia;
												if (achievements != null)
												{
																//foreach (string achievement in achievements)
																for(int i=0; i<achievements.Length; i++)
																{
																				string lineText = "· " + achievements[i];
																				if (i < achievements.Length - 1)
																				{
																								lineText += ",";
																				}
																				Chunk achievementLine = new Chunk(lineText, font);
																				achievementsParagraph.Add(achievementLine);
																				achievementsParagraph.Add(Chunk.NEWLINE);
																}
												}
												else
												{
																Chunk achievementLine = new Chunk(" - ", font);
																achievementsParagraph.Add(achievementLine);
																achievementsParagraph.Add(Chunk.NEWLINE);
												}

												achievementsParagraph.SpacingBefore = 20;
												document.Add(achievementsParagraph);
								}

								private void WriteFooter()
								{
												PdfPTable footer = new PdfPTable(2);
												footer.SpacingBefore = 30;
												footer.WidthPercentage = 100;
												footer.AddCell(getCell(BuildFooterDateText(), PdfPCell.ALIGN_LEFT, font));
												footer.AddCell(getCell(".......................................................", PdfPCell.ALIGN_RIGHT, font));
												document.Add(footer);

												PdfPTable sign = new PdfPTable(1);
												sign.HorizontalAlignment = Element.ALIGN_RIGHT;
												sign.WidthPercentage = 35;
												string text = "podpis Dziekana Wydziału,\n lub Kierownika jednostki organizacyjnej";
												sign.AddCell(getCell(text, PdfPCell.ALIGN_CENTER, smallFont));
												document.Add(sign);
								}

								private PdfPCell getCell(String text, int alignment, Font f)
								{
												PdfPCell cell = new PdfPCell(new Phrase(text, f));
												cell.Padding = 0;
												cell.HorizontalAlignment = alignment;
												cell.Border = PdfPCell.NO_BORDER;
												return cell;
								}

								private string BuildFooterDateText()
								{
												return "Gdańsk, dnia " + BuildDate(documentObject.data_zlozenia);
								}

				}
}
