using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab6.Zad10_1;


//W klasie Grupa zdefiniuj zdarzenie sprawdzania obecności członków grupy. Każdy z nich powinien się zgłosić podając imię i nazwisko.

internal class Zad10_1
{
    public void main(string[] args)
    {

        Grupa grupa = new Grupa("GrupaSzkolna");
        grupa.dodajCzlonka(new Osoba("Jan", "Mazur"));
        grupa.SprawdzanieObecnosci += Grupa_SprawdzanieObecnosci;
        grupa.ZglosObecnosc("Jan", "Kowalski");
        grupa.ZglosObecnosc("Jan", "Mazur");
    }
    private static void Grupa_SprawdzanieObecnosci(object sender, Osoba e)
    {
        Console.WriteLine($"Czy obecny: {e.Imie} {e.Nazwisko}");
    }
}
