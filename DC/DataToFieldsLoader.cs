using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    // wypełniacz okienek
    // a może interfejs?
    // w każdym razie osobna klasa do każdego z okienek
    // i w każdej klasie publiczna funkcja do ładowania danych do okienek i z okienek

    abstract class DataToFieldsLoader
    {
        abstract public void loadDataToFields()
        { }
    }
}
