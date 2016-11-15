using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DC
{
				public partial class MainWindow : Form
				{
								public DateTime Date
								{
												get
												{
																return date.Value;
												}
												set
												{
																date.Value = value;
												}
								}
								public string OrganizationalUnit
								{
												get { return organizationalUnit.Text; }
												set { organizationalUnit.Text = value; }
								}
								public string CandidatName
								{
												get
												{
																return name.Text;
												}
												set
												{
																name.Text = value;
												}
								}
								public string CandidatSurname
								{
												get
												{
																return surname.Text;
												}
												set
												{
																surname.Text = value;
												}
								}
								public string PostCode
								{
												get
												{
																return postCode.Text;
												}
												set
												{
																postCode.Text = value;
												}
								}
								public string City
								{
												get
												{
																return city.Text;
												}
												set
												{
																city.Text = value;
												}
								}
								public string Street
								{
												get
												{
																return street.Text;
												}
												set
												{
																street.Text = value;
												}
								}
								public string HouseNumber
								{
												get
												{
																return houseNumber.Text;
												}
												set
												{
																houseNumber.Text = value;
												}
								}
								public string FlatNumber
								{
												get
												{
																return flatNumber.Text;
												}
												set
												{
																flatNumber.Text = value;
												}
								}
								public string AcademyName
								{
												get
												{
																return academyName.Text;
												}
												set
												{
																academyName.Text = value;
												}
								}
								public string FacultyName
								{
												get
												{
																return facultyName.Text;
												}
												set
												{
																facultyName.Text = value;
												}
								}
								public ListViewTable Titles { get; }
								public ListViewTable ExJobs { get; }
								public List<string> Achievements { get; }
								public string Position
								{
												get { return position.Text; }
												set { position.Text = value; }
								}
								public DateTime StartDate
								{
												get { return startDate.Value; }
												set { startDate.Value = value; }
								}
								public bool IsDefiniteWorkTime
								{
												get 
												{
																if (forPeriod.SelectedIndex == 0)
																{
																				return true;
																}
																else
																{
																				return false;
																}
												}
												set
												{
																if (value == true)
																{
																				forPeriod.SelectedIndex = 0;
																}
																else
																{
																				forPeriod.SelectedIndex = 1;
																}
												}
								}
								public bool IsFullWorkTime
								{
												get { return fullWorkingTimeCheckBox.Checked; }
												set { fullWorkingTimeCheckBox.Checked = value; }
								}
								public DateTime EndDate
								{
												get { return endDate.Value; }
												set { endDate.Value = value; }
								}
								public string WorkTime
								{
												get { return workingTime.Text; }
												set { workingTime.Text = value; }
								}
								public bool IsContract
								{
												get { return contractRadioButton.Checked; }
												set 
												{
																if (value == true)
																{
																				contractRadioButton.Checked = true;
																}
																else
																{
																				nominationRadioButton.Checked = true;
																}
												}
								}

								public void AddTitle(string titleType, string title, string obtainedYear)
								{
												string[] row = new string[3];
												row[0] = titleType;
												row[1] = title;
												row[2] = obtainedYear;
												Titles.Add(row);
												AddToListView(row, titlesTable);
								}

								private void AddToListView(string[] row, ListView listView)
								{
												ListViewItem item = new ListViewItem(row);
												listView.Items.Add(item);
								}

								public void AddExJob(string position, string place, string startYear, string endYear)
								{
												string[] row = new string[4];
												row[0] = position;
												row[1] = place;
												row[2] = startYear;
												row[3] = endYear;
												ExJobs.Add(row);
												AddToListView(row, exJobsTable);
								}

								public void AddAchievement(string achievement)
								{
												Achievements.Add(achievement);
												achievementsList.Items.Add(achievement);
								}

								public void ClearTitles()
								{
												Titles.Clear();
												titlesTable.Items.Clear();
								}

								public void ClearExJobs()
								{
												ExJobs.Clear();
												exJobsTable.Items.Clear();
								}

								public void ClearAchievements()
								{
												Achievements.Clear();
												achievementsList.Items.Clear();
								}

								public MainWindow()
								{
												InitializeComponent();

												IsDefiniteWorkTime = true;
												IsFullWorkTime = true;
												IsContract = true;

												Titles = new List<string[]>();
												ExJobs = new List<string[]>();
												Achievements = new List<string>();
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
												Date = document.data_zlozenia;
												OrganizationalUnit = document.jednostka_organizacyjna;

												CandidatName = document.kandydat.dane_kandydata.imie;
												CandidatSurname = document.kandydat.dane_kandydata.nazwisko;

												Adres address = document.kandydat.dane_kandydata.adres;
												PostCode = address.kod_pocztowy;
												City = address.miejscowosc;
												Street = address.ulica;
												HouseNumber = address.nr_domu;
												FlatNumber = address.nr_mieszkania;

												Uczelnia academy = document.kandydat.ukonczona_uczelnia;
												AcademyName = academy.nazwa_uczelni;
												FacultyName = academy.nazwa_wydzialu;

												Tytuly titles = document.kandydat.uzyskane_tytuly;
												ClearTitles();
												if (titles.tytul_zawodowy != null)
												{
																AddTitle("tytuł zawodowy", titles.tytul_zawodowy.jaki, titles.tytul_zawodowy.data_uzyskania);
												}
												if (titles.stopien_naukowy != null)
												{
																foreach (Stopien_Naukowy degree in titles.stopien_naukowy)
																{
																				AddTitle("stopień naukowy", degree.jaki, degree.data_uzyskania);
																}
												}
												if (titles.tytul_naukowy != null)
												{
																AddTitle("tytuł naukowy", "prof.", titles.tytul_naukowy.data_uzyskania);
												}

												Praca[] jobs = document.kandydat.przebieg_pracy;
												if (jobs != null)
												{
																foreach(Praca job in jobs)
																{
																				AddExJob(job.stanowisko, job.miejsce, job.rok_rozpoczecia, job.rok_zakonczenia);
																}
												}

												if(document.kandydat.osiagniecia != null)
												{
																foreach(string achievement in document.kandydat.osiagniecia)
																{
																				AddAchievement(achievement);
																}
												}

												Zatrudnienie employment = document.zatrudnienie;
												Position = employment.stanowisko;
												StartDate = employment.od_dnia;
												if (employment.czas_zatrudnienia.okreslony)
												{
																IsDefiniteWorkTime = true;
																EndDate = employment.czas_zatrudnienia.do_dnia;
												}
												else
												{
																IsDefiniteWorkTime = false;
												}

												if(employment.wymiar_etatu == "pelny")
												{
																IsFullWorkTime = true;
												}
												else
												{
																IsFullWorkTime = false;
																WorkTime = employment.wymiar_etatu;
												}

												if (employment.podstawa == "umowa o prace")
												{
																IsContract = true;
												}
												else
												{
																IsContract = false;
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
												test();
												
												Wniosek document = loadDataFromFields();
												Serializer<Wniosek> serializer = new Serializer<Wniosek>();
												XmlDocument xml = serializer.loadToXML(document);

												Validator validator = new Validator();
												bool isCorrect = validator.Validate(xml);

												if (isCorrect)
												{
																saveXML(xml, document);
																MessageBox.Show("Zapisano");
												};
								}

								private Wniosek loadDataFromFields()
								{
												Wniosek document = new Wniosek();
												document.data_zlozenia = Date;
												document.jednostka_organizacyjna = OrganizationalUnit;

												document.kandydat = new Kandydat();
												document.kandydat.dane_kandydata = new Dane();
												document.kandydat.dane_kandydata.imie = CandidatName;
												document.kandydat.dane_kandydata.nazwisko = CandidatSurname;
												document.kandydat.dane_kandydata.adres = new Adres();
												document.kandydat.dane_kandydata.adres.kod_pocztowy = PostCode;
												document.kandydat.dane_kandydata.adres.miejscowosc = City;
												document.kandydat.dane_kandydata.adres.ulica = Street;
												document.kandydat.dane_kandydata.adres.nr_domu = HouseNumber;
												document.kandydat.dane_kandydata.adres.nr_mieszkania = FlatNumber;
												document.kandydat.ukonczona_uczelnia = new Uczelnia();
												document.kandydat.ukonczona_uczelnia.nazwa_uczelni = AcademyName;
												document.kandydat.ukonczona_uczelnia.nazwa_wydzialu = FacultyName;
												
												if(Titles.Count != 0)
												{
																document.kandydat.uzyskane_tytuly = new Tytuly();
																List<Stopien_Naukowy> degrees = new List<Stopien_Naukowy>();
																foreach(string[] title in Titles)
																{
																				switch(title[0])
																				{
																								case "tytuł zawodowy":
																												document.kandydat.uzyskane_tytuly.tytul_zawodowy = new Tytul_Zawodowy();
																												document.kandydat.uzyskane_tytuly.tytul_zawodowy.jaki = title[1];
																												document.kandydat.uzyskane_tytuly.tytul_zawodowy.data_uzyskania = title[2];
																												break;
																								case "stopień naukowy":
																												Stopien_Naukowy degree = new Stopien_Naukowy();
																												degree.jaki = title[1];
																												degree.data_uzyskania = title[2];
																												degrees.Add(degree);
																												break;
																								case "tytuł naukowy":
																												document.kandydat.uzyskane_tytuly.tytul_naukowy = new Tytul_Naukowy();
																												document.kandydat.uzyskane_tytuly.tytul_naukowy.data_uzyskania = title[2];
																												break;
																				}
																}
																if (degrees.Count != 0)
																{
																				document.kandydat.uzyskane_tytuly.stopien_naukowy = degrees.ToArray();
																}
												}
												
												if(ExJobs.Count != 0)
												{
																List<Praca> jobs = new List<Praca>();
																foreach(string[] row in ExJobs)
																{
																				Praca job = new Praca();
																				job.stanowisko = row[0];
																				job.miejsce = row[1];
																				job.rok_rozpoczecia = row[2];
																				job.rok_zakonczenia = row[3];
																				jobs.Add(job);
																}
																document.kandydat.przebieg_pracy = jobs.ToArray();
												}

												if(Achievements.Count != 0)
												{
																document.kandydat.osiagniecia = Achievements.ToArray();
												}

												document.zatrudnienie = new Zatrudnienie();
												document.zatrudnienie.stanowisko = Position;
												document.zatrudnienie.od_dnia = StartDate;
												document.zatrudnienie.czas_zatrudnienia = new Czas_Zatrudnienia();
												document.zatrudnienie.czas_zatrudnienia.okreslony = IsDefiniteWorkTime;
												if(IsDefiniteWorkTime)
												{
																document.zatrudnienie.czas_zatrudnienia.do_dnia = EndDate;
												}

												if(IsFullWorkTime)
												{
																document.zatrudnienie.wymiar_etatu = "pelny";
												}
												else
												{
																document.zatrudnienie.wymiar_etatu = WorkTime;
												}

												if(IsContract)
												{
																document.zatrudnienie.podstawa = "umowa o prace";
												}
												else
												{
																document.zatrudnienie.podstawa = "mianowanie";
												}

												return document;
								}

								private void saveXML(XmlDocument xml, Wniosek document)
								{
												string path = "wniosek"
																								+ document.kandydat.dane_kandydata.imie
																								+ document.kandydat.dane_kandydata.nazwisko
																								+ "_mod.xml";
												xml.Save(path);
								}

								private void test()
								{
												
								}
				}
}
