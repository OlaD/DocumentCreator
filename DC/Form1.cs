using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC
{
				public partial class mainWindow : Form
				{
								public mainWindow()
								{
												InitializeComponent();

												forPeriod.SelectedIndex = 0;
								}

								private void loadXml_Click(object sender, EventArgs e)
								{
												if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
												{
																Serializer<Wniosek> serializer = new Serializer<Wniosek>();
																Wniosek document = serializer.loadFromXML(openFileDialog.FileName);
																fillFields(document);
												}
								}

								private void fillFields(Wniosek document)
								{
												date.Value = document.data_zlozenia;

												name.Text = document.kandydat.dane_kandydata.imie;
												surname.Text = document.kandydat.dane_kandydata.nazwisko;

												Adres address = document.kandydat.dane_kandydata.adres;
												postCode.Text = address.kod_pocztowy;
												city.Text = address.miejscowosc;
												street.Text = address.ulica;
												houseNumber.Text = address.nr_domu;
												flatNumber.Text = address.nr_mieszkania;

												Uczelnia academy = document.kandydat.ukonczona_uczelnia;
												academyName.Text = academy.nazwa_uczelni;
												facultyName.Text = academy.nazwa_wydzialu;

												Tytuly titles = document.kandydat.uzyskane_tytuly;
												titlesTable.Items.Clear();
												if (titles.tytul_zawodowy != null)
												{
																string[] row = new string[3];
																row[0] = "Tytuł zawodowy";
																row[1] = titles.tytul_zawodowy.jaki;
																row[2] = titles.tytul_zawodowy.data_uzyskania;
																ListViewItem item = new ListViewItem(row);
																titlesTable.Items.Add(item);
												}
												if (titles.stopien_naukowy != null)
												{
																foreach (Stopien_Naukowy degree in titles.stopien_naukowy)
																{
																				string[] row = new string[3];
																				row[0] = "Stopień naukowy";
																				row[1] = degree.jaki;
																				row[2] = degree.data_uzyskania;
																				ListViewItem item = new ListViewItem(row);
																				titlesTable.Items.Add(item);
																}
												}
												if (titles.tytul_naukowy != null)
												{
																string[] row = new string[3];
																row[0] = "Tytuł naukowy";
																row[1] = "prof.";
																row[2] = titles.tytul_naukowy.data_uzyskania;
																ListViewItem item = new ListViewItem(row);
																titlesTable.Items.Add(item);
												}

												Praca[] jobs = document.kandydat.przebieg_pracy;
												if (jobs != null)
												{
																foreach(Praca job in jobs)
																{
																				string[] row = new string[4];
																				row[0] = job.stanowisko;
																				row[1] = job.miejsce;
																				row[2] = job.rok_rozpoczecia;
																				row[3] = job.rok_zakonczenia;
																				ListViewItem item = new ListViewItem(row);
																				exJobsTable.Items.Add(item);
																}
												}

												achievementsList.DataSource = document.kandydat.osiagniecia;

												Zatrudnienie employment = document.zatrudnienie;
												position.Text = employment.stanowisko;
												startDate.Value = employment.od_dnia;
												if (employment.czas_zatrudnienia.okreslony)
												{
																forPeriod.SelectedIndex = 0;
																endDate.Value = employment.czas_zatrudnienia.do_dnia;
												}
												else
												{
																forPeriod.SelectedIndex = 1;
												}

												if(employment.wymiar_etatu == "pelny")
												{
																fullWorkingTimeCheckBox.Checked = true;
												}
												else
												{
																fullWorkingTimeCheckBox.Checked = false;
																workingTime.Text = employment.wymiar_etatu;
												}

												if (employment.podstawa == "umowa o prace")
												{
																contractRadioButton.Checked = true;
												}
												else
												{
																nominationRadioButton.Checked = true;
												}
								}

								private void forPeriod_SelectedIndexChanged(object sender, EventArgs e)
								{
												if(forPeriod.SelectedIndex == 0)				// czas zatrudnienia == określony
												{
																endDate.Visible = true;
																endDateLabel.Visible = true;
												}
												else
												{
																endDate.Visible = false;
																endDateLabel.Visible = false;
												}
								}

								private void fullWorkingTimeCheckBox_CheckedChanged(object sender, EventArgs e)
								{
												if (fullWorkingTimeCheckBox.Checked)
												{
																workingTime.Visible = false;
																workingTimeLabel.Visible = false;
												}
												else 
												{
																workingTime.Visible = true;
																workingTimeLabel.Visible = true;
												}
								}

								private void walidateAndSave_Click(object sender, EventArgs e)
								{
												// zapisz dane z kontrolek do klasy
												//	serializuj klasę do pliku xml
												// waliduj plik xml
												// zapisz plik xml			

												/* MemoryStream ms = new MemoryStream(); //creating a stream for storing XML file with modified data

            XmlWriter writer = XmlWriter.Create(ms); //creating writer for writing XML file to stream
            xmlser.Serialize(writer, zamowienie1);

            XmlReaderSettings xrset = new XmlReaderSettings(); //definition of XML reader settings
            xrset.ValidationType = ValidationType.Schema; //validation based on XML Schema
            ms.Position = 0; //setting the pointer on beginning of memory stream
            XmlReader reader = XmlReader.Create(ms,xrset); //creating a reader for reading XML from memory stream

            XmlDocument xdoc = new XmlDocument(); //creating an XML document
            xdoc.Load(reader); //loading document from memory stream
            xdoc.Schemas.Add(null, @"zamowienie.xsd"); //connecting the XML document with schema from "zamowienie.xsd"
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventCallback); //setting the event handler for handling incorrect validation events
            XMLValid = true; //setting the default value of XML validity flag for true
            xdoc.Validate(eventHandler); //performing validation
            
           //Writing the memory stream to a file "zamowienie_mod.xml" if the document is valid
            if (XMLValid)
            {
                FileStream fs = new FileStream("zamowienie_mod.xml", FileMode.Create);
                ms.Position = 0;
                ms.CopyTo(fs);
                fs.Close();
                //toolStripStatusLabel2.Text = "XML valid - marshalling to \"zamowienie_mod.xml\" file";
                toolStripStatusLabel2.Text = "Walidacja XML pomyślna - dane zapisano do pliku \"zamowienie_mod.xml\"";
            }
            else
            {
                //toolStripStatusLabel2.Text = "XML invalid";
                toolStripStatusLabel2.Text = "Nieprawidłowe dane dokumentu";
            }
            ms.Close();*/
								}
				}
}
