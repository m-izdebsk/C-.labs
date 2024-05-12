using CSLab.Lab4.Zad6_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab4.Zad6_2
{
    class Zad6_2
    {
        public void main(string[] args)
        {
            Osoba osoba = new Osoba { Imie = "Miz", Nazwisko = "Kowalski" };
            osoba.PrzypiszAdres("ul. Wiejska 10", "Warszawa", "00-001");
            osoba.WypiszDaneZAdresem();
        }
    }
}
