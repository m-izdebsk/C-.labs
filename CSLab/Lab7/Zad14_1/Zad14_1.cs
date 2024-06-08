/*
 

Funkcje anonimowe

XIV.1. Kod bazowy z projektu funkcje_anonimowe_2
W klasie Grupa dodaj metodę obliczania średniego wzrostu członków grupy. Użyj odpowiednich metod rozszerzających na tablicy członków grupy. Metody te są dostępne po zaimportowaniu przestrzeni nazw System.Linq.



 */
namespace CSLab.Lab7.Zad14_1;

internal class Zad14_1
{
    public void main(string[] args) {
        var os = new Osoba("test1n0", "test1");
        var os2 = new Osoba("test1n1", "test2");
        var os3 = new Osoba("test1n2", "test3");
        var grupa = new Grupa("test group");
        var grupa2 = new Grupa("test group2");
        //dodanie 3 czlonkow
        grupa.dodajCzlonka(os);
        grupa.dodajCzlonka(os2);
        grupa.dodajCzlonka(os3);

        Console.WriteLine(grupa.ObliczSredniWzrost());
    }
}
