using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
				static class Fields
				{
								public static bool incorrectTitleYear;

								public enum Field
								{
												name,
												surname,
												city,
												postCode,
												titles,
												workTime
								}

								public static Dictionary<Field, string> fieldsPaths = new Dictionary<Field, string>()
								{
												{ Field.name, @"/wniosek/kandydat/dane_kandydata/imie" },
												{ Field.surname, @"/wniosek/kandydat/dane_kandydata/nazwisko" },
												{ Field.city, @"/wniosek/kandydat/dane_kandydata/adres/miejscowosc" },
												{ Field.postCode, @"/wniosek/kandydat/dane_kandydata/adres/kod_pocztowy" },
												{ Field.workTime, @"/wniosek/zatrudnienie/wymiar_etatu" },
												{ Field.titles, @"/wniosek/kandydat/uzyskane_tytuly" }
								};

								public static Dictionary<Field, string> fieldsMessages = new Dictionary<Field, string>()
								{
												{Field.name, "Imię: może zawierać tylko litery i musi zaczynać się z wielkiej litery." },
												{Field.surname, "Nazwisko: może zawierać tylko litery i musi zaczynać się z wielkiej litery. W nazwiskach wieloczłonowych człony muszą być oddzielone myślnikiem." },
												{Field.city, "Miejscowość: może zawierać tylko litery i musi zaczynać się z wielkiej litery." },
												{Field.postCode, "Kod pocztowy: musi składać się z liczb w formacie: 00-000" },
												{Field.workTime, "Wymiar etatu: może być pełny lub niepełny. Niepełny etat wyraża się ułamkiem zapisanym w formacie: x/y" },
												{Field.titles, "Uzyskane tytuły: kandydat musi mieć uzyskany przynajmniej tytuł zawodowy. Tytuł zawodowy i tytuł naukowy może być tylko 1. Stopnie naukowe mogą być 2." },
								};
				}
}
