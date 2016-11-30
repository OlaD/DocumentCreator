using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
				class DocumentCreator
				{
								MainWindow window;

								DocumentCreator(MainWindow window)
								{
												this.window = window;
								}

								public Wniosek Create()
								{
												Wniosek document = LoadDocumentData();
												document.kandydat = LoadCandidat();

												return document;
								}

								private Wniosek LoadDocumentData()
								{
												Wniosek document = new Wniosek();
												document.data_zlozenia = window.Date;
												document.jednostka_organizacyjna = window.OrganizationalUnit;
												return document;
								}

								private Kandydat LoadCandidat()
								{
												Kandydat candidat = new Kandydat();
												candidat.dane_kandydata = LoadCandidatData();
												candidat.dane_kandydata.adres = LoadAddress();
												candidat.ukonczona_uczelnia = LoadAcademy();
												candidat.uzyskane_tytuly = LoadTitles();
												return candidat;
								}

								private Dane LoadCandidatData()
								{
												Dane data = new Dane();
												data.imie = window.CandidatName;
												data.nazwisko = window.CandidatSurname;
												return data;
								}

								private Adres LoadAddress()
								{
												Adres address = new Adres();
												address.kod_pocztowy = window.PostCode;
												address.miejscowosc = window.City;
												address.ulica = window.Street;
												address.nr_domu = window.HouseNumber;
												address.nr_mieszkania = window.FlatNumber;
												return address;
								}

								private Uczelnia LoadAcademy()
								{
												Uczelnia academy = new Uczelnia();
												academy.nazwa_uczelni = window.AcademyName;
												academy.nazwa_wydzialu = window.FacultyName;
												return academy;
								}

								private Tytuly LoadTitles()
								{
												Tytuly titles = null;
												if (window.Titles.Count != 0)
												{
																titles = new Tytuly();
																List<Stopien_Naukowy> degrees = new List<Stopien_Naukowy>();
																foreach (string[] title in window.Titles.GetAllRows())
																{
																				switch (title[0])
																				{
																								case "tytuł zawodowy":
																												titles.tytul_zawodowy = new Tytul_Zawodowy();
																												titles.tytul_zawodowy.jaki = title[1];
																												titles.tytul_zawodowy.data_uzyskania = title[2];
																												break;
																								case "stopień naukowy":
																												Stopien_Naukowy degree = new Stopien_Naukowy();
																												degree.jaki = title[1];
																												degree.data_uzyskania = title[2];
																												degrees.Add(degree);
																												break;
																								case "tytuł naukowy":
																												titles.tytul_naukowy = new Tytul_Naukowy();
																												titles.tytul_naukowy.data_uzyskania = title[2];
																												break;
																				}
																}
																if (degrees.Count != 0)
																{
																				titles.stopien_naukowy = degrees.ToArray();
																}
												}
												return titles;
								}

				}
}
