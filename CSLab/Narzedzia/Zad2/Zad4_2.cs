using System.Diagnostics;

namespace CSLab.Narzedzia.Zad2;

internal class Zad4_2
{
    internal void main(string[] args)
    {
        var os = new Osoba("test1n", "test1");
        var os2 = new Osoba("test1n", "test2");
        var os3 = new Osoba("test1n", "test3");
        var grupa = new Grupa("test group");
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