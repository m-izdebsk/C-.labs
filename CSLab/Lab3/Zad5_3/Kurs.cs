﻿using CSLab.Labs._2._9;

namespace CSLab.Lab3.Zad5_3
{
    class Kurs
    {
        private string nazwaKursu;
        private int liczbaGodzin;
        private Osoba osoba; //korzystamy z klas osoba
        private Narzedzia.Zad2.Grupa[] grupa;
        // Konstruktor klasy "kurs"

        public Kurs(string nazwaKursu, int liczbaGodzin, Osoba wykladowca, Narzedzia.Zad2.Grupa[] grupaCwiczeniowa)
        {
            this.nazwaKursu = nazwaKursu;
            this.liczbaGodzin = liczbaGodzin;
            osoba = wykladowca;
            grupa = grupaCwiczeniowa;
        }

        // Metoda wypisująca dane kursu
        public void printData()
        {
            Console.WriteLine("Nazwa kursu: " + nazwaKursu);
            Console.WriteLine("Liczba godzin: " + liczbaGodzin);
            Console.WriteLine("Wykładowca: " + osoba.Imie + " " + osoba.Nazwisko);
            Console.WriteLine("Grupa ćwiczeniowa - wielkosc: " + grupa.Length);
        }
    }
}
