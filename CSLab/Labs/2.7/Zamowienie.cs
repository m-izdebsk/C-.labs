﻿
/*

Utwórz klasę Zamowienie.
W klasie zdefiniuj pola reprezentujące datę realizacji, nazwę klienta, pozycje zamównienia (jako tablicę obiektów klasy Sprzedaz,
zakładając obecność maksymalnie 20-stu pozycji w jednym zamówieniu).
Zaimplementuj konstruktor, który przekazuje datę i kupującego oraz przydziela pamięć dla tablicy pozycji zamówienia.
Zaimplementuj metodę dodajPozycje() dodającą do zamówienia kolejną pozycję. Zaimplementuj dwie postaci tej metody:
dodajPozycje(Sprzedaz pozycja) oraz dodajPozycje(string p, int a, decimal sP).
Zaimplementuj metodę wypisującą informacje o zamówieniu (w tym informacje o wszystkich pozycjach tego zamówienia) na konsoli.

*/
namespace CSLab.Labs._2._7;

public class Zamowienie
{
    private int _counter;
    private readonly DateTime dataRealizacji;
    private readonly string nazwaKlienta;
    private readonly Sprzedaz[] pozycjeZamowienia;

    public Zamowienie(DateTime data, string klient)
    {
        dataRealizacji = data;
        nazwaKlienta = klient;
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

    public void DodajPozycje(string p, int a, decimal sP)
    {
        if (_counter == 20)
        {
            Console.WriteLine("Nie można dodać więcej pozycji!");
            return;
        }

        pozycjeZamowienia[_counter++] = new Sprzedaz(p, a, sP);
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
}