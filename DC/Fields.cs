using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
				static class Fields
				{
								public enum Field
								{
												imie,
								}

								public static Dictionary<Field, string> fieldsPaths = new Dictionary<Field, string>()
								{
												{ Field.imie, @"/wniosek/kandydat/dane_kandydata/imie" }
								};

								public static Dictionary<Field, string> fieldsMessages = new Dictionary<Field, string>()
								{
												{Field.imie, "Imię musi składać się z jednego słowa zaczynającego się od wielkiej litery." }
								};
				}
}
