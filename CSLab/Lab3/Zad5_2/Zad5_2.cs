using System.Diagnostics;

namespace CSLab.Lab3.Zad5_2;

internal class Zad5_2
{
    internal void main(string[] args)
    {
        var os = new Osoba("test1n0", "test1");
        var os2 = new Osoba("test1n1", "test2");
        var os3 = new Osoba("test1n2", "test3");
        var grupa = new Grupa("test group");
        var grupa2 = new Grupa("test group2");
        //dodanie 3 czlonkow
        grupa.dodajCzlonka(os);
        grupa.dodajCzlonka(os2);
        grupa.dodajCzlonka(os3);
        grupa2.dodajCzlonka(os);
        Debug.Assert(grupa.czyJestWieksza(grupa2));
        Debug.Assert(grupa.czyJestWiekszaLiczbaOsob(grupa2));
        Console.WriteLine(
            grupa.czyJestWieksza(grupa2));
        Console.WriteLine(
            grupa.czyJestWiekszaLiczbaOsob(grupa2));
        //sprawdzenie rozumaru grupy
        Debug.Assert(grupa.rozmiar == 3);
        grupa.usunCzlonka(os2);
        //Debug.Assert(grupa.rozmiar == 2);
        grupa.usunCzlonka("test1");
        Console.WriteLine(grupa.rozmiar);
        //Debug.Assert(grupa.rozmiar == 1);
    }
}