using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;
using System.Windows.Forms;
using System;
using System.Text;

namespace DC
{
				class PDFGenerator
				{
								const int FONT_SIZE = 12;
								const int SMALL_FONT_SIZE = 6;
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

								public void GeneratePDF()
								{
												document = CreateDocument("tmp.pdf");
												document.Open();
												CreateFonts();
												WriteAll();
												document.Close();

												MessageBox.Show("Wygenerowano PDF");
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
												// TODO większy odstęp między wyrazami
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
												text.Append(date.Month);
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
				}
}
