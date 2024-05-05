﻿namespace CSLab.Narzedzia.Zad2;

internal class Grupa
{
    public Osoba[] czlonkowie = new Osoba[0];
    public string Nazwa;
    public int rozmiar;

    public Grupa(string nazwa)
    {
        Nazwa = nazwa;
        rozmiar = 0;
    }

    public void dodajCzlonka(Osoba czlonek)
    {
        var destinationArray = new Osoba[czlonkowie.Length + 1];
        Array.Copy(czlonkowie, destinationArray, czlonkowie.Length);
        destinationArray[czlonkowie.Length] = czlonek;
        czlonkowie = destinationArray;
        Console.WriteLine(czlonkowie.Length);
        rozmiar++;
    }

    public void usunCzlonka(Osoba czlonek)
    {
        for (var i = 0; i < czlonkowie.Length; i++)
            if (czlonkowie[i] == czlonek)
            {
                usunCzlonka(i);
                break;
            }
    }

    public void usunCzlonka(int czlonek)
    {
        if (czlonek < czlonkowie.Length)
        {
            var removed = czlonkowie[czlonek];

            //przesun czlonka
            for (var i = czlonek; i < czlonkowie.Length; i++) czlonkowie[i - 1] = czlonkowie[i];
        }
    }
}