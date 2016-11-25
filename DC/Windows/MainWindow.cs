﻿using System;
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
	public ListBoxTable Achievements { get; }
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

	private Presenter presenter;

	public MainWindow()
	{
					InitializeComponent();

					presenter = new Presenter(this);

					IsDefiniteWorkTime = true;
					IsFullWorkTime = true;
					IsContract = true;

					Titles = new ListViewTable(titlesTable);
					ExJobs = new ListViewTable(exJobsTable);
					Achievements = new ListBoxTable(achievementsList);
	}

	private void loadXml_Click(object sender, EventArgs e)
	{
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                presenter.loadDataToFields(openFileDialog.FileName);
            }
	}

	private void fillFields(Wniosek document)
	{
					Titles.Clear();
					ExJobs.Clear();
					Achievements.Clear();

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
												
					if (titles.tytul_zawodowy != null)
					{
									Titles.Add(new string[] { "tytuł zawodowy", titles.tytul_zawodowy.jaki, titles.tytul_zawodowy.data_uzyskania });
					}
					if (titles.stopien_naukowy != null)
					{
									foreach (Stopien_Naukowy degree in titles.stopien_naukowy)
									{
													Titles.Add(new string[] { "stopień naukowy", degree.jaki, degree.data_uzyskania });
									}
					}
					if (titles.tytul_naukowy != null)
					{
									Titles.Add(new string[] { "tytuł naukowy", "prof.", titles.tytul_naukowy.data_uzyskania });
					}

					Praca[] jobs = document.kandydat.przebieg_pracy;
					if (jobs != null)
					{
									foreach(Praca job in jobs)
									{
													ExJobs.Add(new string[] { job.stanowisko, job.miejsce, job.rok_rozpoczecia, job.rok_zakonczenia });
									}
					}

					if(document.kandydat.osiagniecia != null)
					{
									foreach(string achievement in document.kandydat.osiagniecia)
									{
													Achievements.Add(achievement);
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
									foreach(string[] title in Titles.GetAllRows())
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
									foreach (string[] row in ExJobs.GetAllRows())
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
									document.kandydat.osiagniecia = Achievements.GetAllRows().ToArray();
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

	private void titlesTable_SelectedIndexChanged(object sender, EventArgs e)
	{
					if (Titles.SelectedIndex != -1)
					{
									editTitle.Enabled = true;
									removeTitle.Enabled = true;
					}
					else 
					{
									editTitle.Enabled = false;
									removeTitle.Enabled = false;
					}
	}

	private void achievementsList_SelectedIndexChanged(object sender, EventArgs e)
	{
					if (Achievements.SelectedIndex != -1)
					{
									editAchievement.Enabled = true;
									removeAchievement.Enabled = true;
					}
					else
					{
									editAchievement.Enabled = false;
									removeAchievement.Enabled = false;
					}
	}

	private void exJobsTable_SelectedIndexChanged(object sender, EventArgs e)
	{
					if (ExJobs.SelectedIndex != -1)
					{
									editExJob.Enabled = true;
									removeExJob.Enabled = true;
					}
					else
					{
									editExJob.Enabled = false;
									removeExJob.Enabled = false;
					}
	}

	private void addTitle_Click(object sender, EventArgs e)
	{
					using (TitleWindow window = new TitleWindow(TitleWindow.Operation.Add))
					{
									var result = window.ShowDialog();
									if(result == DialogResult.OK)
									{
													string[] row = window.Values;
													Titles.Add(row);
									}
					}
	}

	private void editTitle_Click(object sender, EventArgs e)
	{
					using (TitleWindow window = new TitleWindow(TitleWindow.Operation.Edit, Titles.GetSelectedRow()))
					{
									var result = window.ShowDialog();
									if (result == DialogResult.OK)
									{
													string[] editedValues = window.Values;
													Titles.EditSelectedRow(editedValues);
									}
					}
	}

	private void removeTitle_Click(object sender, EventArgs e)
	{
					Titles.RemoveSelected();
	}

	private void exJobAdd_Click(object sender, EventArgs e)
	{
					using (ExJobWindow window = new ExJobWindow(ExJobWindow.Operation.Add))
					{
									var result = window.ShowDialog();
									if (result == DialogResult.OK)
									{
													string[] row = window.Values;
													ExJobs.Add(row);
									}
					}
	}

	private void exJobEdit_Click(object sender, EventArgs e)
	{
					using (ExJobWindow window = new ExJobWindow(ExJobWindow.Operation.Edit, ExJobs.GetSelectedRow()))
					{
									var result = window.ShowDialog();
									if (result == DialogResult.OK)
									{
													string[] editedValues = window.Values;
													ExJobs.EditSelectedRow(editedValues);
									}
					}
	}

	private void exJobRemove_Click(object sender, EventArgs e)
	{
					ExJobs.RemoveSelected();
	}

	private void addAchievement_Click(object sender, EventArgs e)
	{
					using (AchievementWindow window = new AchievementWindow(AchievementWindow.Operation.Add))
					{
									var result = window.ShowDialog();
									if (result == DialogResult.OK)
									{
													string row = window.Value;
													Achievements.Add(row);
									}
					}
	}

	private void editAchievement_Click(object sender, EventArgs e)
	{
					using (AchievementWindow window = new AchievementWindow(AchievementWindow.Operation.Edit, Achievements.GetSelectedRow()))
					{
									var result = window.ShowDialog();
									if (result == DialogResult.OK)
									{
													string row = window.Value;
													Achievements.EditSelectedRow(row);
									}
					}
	}

	private void removeAchievement_Click(object sender, EventArgs e)
	{
					Achievements.RemoveSelected();
	}

	private void forPeriod_SelectedIndexChanged(object sender, EventArgs e)
	{
					if (forPeriod.SelectedIndex == 0)    // czas zatrudnienia == określony
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
									workingTime.Enabled = false;
									workingTime.Text = "pełny";
									workingTimeLabel.Enabled = false;
									workingTimeLabel.Text = "etat";
					}
					else
					{
									workingTime.Enabled = true;
									workingTime.Text = "";
									workingTimeLabel.Enabled = true;
									workingTimeLabel.Text = "etatu";
					}
	}

	private void validateAndSave_Click(object sender, EventArgs e)
	{
					Wniosek document = loadDataFromFields();
					Serializer<Wniosek> serializer = new Serializer<Wniosek>();
					XmlDocument xml = serializer.loadToXML(document);

					Validator validator = new Validator();
					bool isCorrect = validator.Validate(xml);

					if (isCorrect)
					{
									if(saveXML(xml, document))
									{
													MessageBox.Show("Zapisano");
									}
					};
	}

	private bool saveXML(XmlDocument xml, Wniosek document)
	{
					if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
									xml.Save(saveFileDialog.FileName);
									return true;
					}
					return false;
	}
}
}
