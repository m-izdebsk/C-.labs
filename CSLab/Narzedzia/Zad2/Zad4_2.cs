using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Narzedzia.Zad2
{
    internal class Zad4_2
    {
        internal void main(string[] args)
        {
            Osoba os = new Osoba("test1n", "test1");
            Osoba os2 = new Osoba("test1n", "test2");
            Osoba os3 = new Osoba("test1n", "test3");
            Grupa grupa = new Grupa("test group");
            //dodanie 3 czlonkow
            grupa.dodajCzlonka(os);
            grupa.dodajCzlonka(os2);
            grupa.dodajCzlonka(os3);
            //sprawdzenie rozumaru grupy
            Debug.Assert(grupa.rozmiar == 3);
            grupa.usunCzlonka(os2);
            Debug.Assert(grupa.rozmiar == 2);


        }
    }
}
