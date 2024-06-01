namespace CSLab.Zad2._3;
using System;
using System.Collections.Generic;

public delegate int ComparisonDelegate(Osoba o1, Osoba o2);
public delegate void SortAlgorithmDelegate(List<Osoba> osoby, ComparisonDelegate compare);

public class Osoba
{
    public string Imie;

    public string Nazwisko;

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
}