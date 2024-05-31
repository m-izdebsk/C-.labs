
/*

Utwórz klasę Zamowienie.
W klasie zdefiniuj pola reprezentujące datę realizacji, nazwę klienta, pozycje zamównienia (jako tablicę obiektów klasy Sprzedaz,
zakładając obecność maksymalnie 20-stu pozycji w jednym zamówieniu).
Zaimplementuj konstruktor, który przekazuje datę i kupującego oraz przydziela pamięć dla tablicy pozycji zamówienia.
Zaimplementuj metodę dodajPozycje() dodającą do zamówienia kolejną pozycję. Zaimplementuj dwie postaci tej metody:
dodajPozycje(Sprzedaz pozycja) oraz dodajPozycje(string p, int a, decimal sP).
Zaimplementuj metodę wypisującą informacje o zamówieniu (w tym informacje o wszystkich pozycjach tego zamówienia) na konsoli.

*/
using System.Runtime.CompilerServices;

namespace CSLab.Lab5.Zad8_4;

public class Zamowienie
{
    private int _counter;
    private readonly DateTime dataRealizacji;
    private readonly Osoba nazwaKlienta;
    private Sprzedaz[] pozycjeZamowienia;

    public Zamowienie(DateTime data, string klient)
    {
        dataRealizacji = data;
        nazwaKlienta = new Osoba(klient, klient);
        pozycjeZamowienia = new Sprzedaz[20];
    }


    public void DodajPozycje(Sprzedaz pozycja)
    {
        if (_counter == 20)
        {
            Console.WriteLine("Nie można dodać więcej pozycji!");
            return;
        }

        pozycjeZamowienia[_counter++] = pozycja;
    }

    public void DodajPozycje(string p, int a, double sP)
    {
        if (_counter == 20)
        {
            Console.WriteLine("Nie można dodać więcej pozycji!");
            return;
        }

        var produkt = new Produkt(p, 1.0f, "kg", DateTime.Now, 24);
        pozycjeZamowienia[_counter++] = new Sprzedaz(produkt, a, sP);
    }

    public void info()
    {
        Console.WriteLine($"Data realizacji: {dataRealizacji}");
        Console.WriteLine($"Nazwa klienta: {nazwaKlienta}");

        for (var i = 0; i < _counter; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Pozycja nr {i + 1}");
            pozycjeZamowienia[i].printData();
            Console.WriteLine();
        }
    

    }
    public static implicit operator Zamowienie(Produkt[] produkty)
    {
        Zamowienie zam = new Zamowienie(DateTime.Now,"zamowienie implicit");
        
        for (int i = 0; i < produkty.Length; i++) {
            Produkt current = produkty[i];
            zam.DodajPozycje(new Sprzedaz(current, 1, current.cena));
        }
        return zam;
    }

    public static explicit operator double(Zamowienie zamówienie)
    {
        double suma = 0;
        foreach (Sprzedaz pozycja in zamówienie.pozycjeZamowienia)
        {
            suma += pozycja.cena * pozycja.ilosc;
        }
        return suma;
    }
}