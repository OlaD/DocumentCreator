namespace DC
{
				class FormFiller
				{
								MainWindow window;				

								public FormFiller(MainWindow window)
								{
												this.window = window;
								}

								public void FillFields(Wniosek document)
								{
												ClearTables();

												FillDocumentData(document);
												FillCandidatName(document.kandydat.dane_kandydata);
												FillAddress(document.kandydat.dane_kandydata.adres);
												FillAcademyData(document.kandydat.ukonczona_uczelnia);
												FillTitles(document.kandydat.uzyskane_tytuly);
												FillJobs(document.kandydat.przebieg_pracy);
												FillAchievements(document.kandydat.osiagniecia);
												FillEmploymentData(document.zatrudnienie);
								}

								private void ClearTables()
								{
												window.Titles.Clear();
												window.ExJobs.Clear();
												window.Achievements.Clear();
								}

								private void FillDocumentData(Wniosek document)
								{
												window.Date = document.data_zlozenia;
												window.OrganizationalUnit = document.jednostka_organizacyjna;
								}

								private void FillCandidatName(Dane data)
								{
												window.CandidatName = data.imie;
												window.CandidatSurname = data.nazwisko;
								}

								private void FillAddress(Adres address)
								{
												window.PostCode = address.kod_pocztowy;
												window.City = address.miejscowosc;
												window.Street = address.ulica;
												window.HouseNumber = address.nr_domu;
												window.FlatNumber = address.nr_mieszkania;
								}

								private void FillAcademyData(Uczelnia academy)
								{
												window.AcademyName = academy.nazwa_uczelni;
												window.FacultyName = academy.nazwa_wydzialu;
								}

								private void FillTitles(Tytuly titles)
								{
												if (titles.tytul_zawodowy != null)
												{
																window.Titles.Add(new string[] { "tytuł zawodowy", titles.tytul_zawodowy.jaki, titles.tytul_zawodowy.data_uzyskania });
												}
												if (titles.stopien_naukowy != null)
												{
																foreach (Stopien_Naukowy degree in titles.stopien_naukowy)
																{
																				window.Titles.Add(new string[] { "stopień naukowy", degree.jaki, degree.data_uzyskania });
																}
												}
												if (titles.tytul_naukowy != null)
												{
																window.Titles.Add(new string[] { "tytuł naukowy", "prof.", titles.tytul_naukowy.data_uzyskania });
												}
								}

								private void FillJobs(Praca[] jobs)
								{
												if (jobs != null)
												{
																foreach (Praca job in jobs)
																{
																				window.ExJobs.Add(new string[] { job.stanowisko, job.miejsce, job.rok_rozpoczecia, job.rok_zakonczenia });
																}
												}
								}

								private void FillAchievements(string[] achievements)
								{
												if (achievements != null)
												{
																foreach (string achievement in achievements)
																{
																				window.Achievements.Add(achievement);
																}
												}
								}

								private void FillEmploymentData(Zatrudnienie employment)
								{
												window.Position = employment.stanowisko;
												window.StartDate = employment.od_dnia;
												if (employment.czas_zatrudnienia.okreslony)
												{
																window.IsDefiniteWorkTime = true;
																window.EndDate = employment.czas_zatrudnienia.do_dnia;
												}
												else
												{
																window.IsDefiniteWorkTime = false;
												}

												if (employment.wymiar_etatu == "pelny")
												{
																window.IsFullWorkTime = true;
												}
												else
												{
																window.IsFullWorkTime = false;
																window.WorkTime = employment.wymiar_etatu;
												}

												if (employment.podstawa == "umowa o prace")
												{
																window.IsContract = true;
												}
												else
												{
																window.IsContract = false;
												}
								}
				}
}
