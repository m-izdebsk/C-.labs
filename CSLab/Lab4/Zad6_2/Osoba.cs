using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab4.Zad6_2
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;
        // Struktura Adres
        public struct Adres
        {
            public string Ulica;
            public string Miasto;
            public string KodPocztowy;
            // Konstruktor struktury Adres
            public Adres(string ulica, string miasto, string kodPocztowy)
            {
                Ulica = ulica;
                Miasto = miasto;
                KodPocztowy = kodPocztowy;
            }
        }



        private Adres adresOsoby;



        // Metoda przypisująca adres osobie

        public void PrzypiszAdres(string ulica, string miasto, string kodPocztowy)
        {

            adresOsoby = new Adres(ulica, miasto, kodPocztowy);

        }



        // Metoda wypisująca dane pracownika wraz z adresem

        public void WypiszDaneZAdresem()
        {
            Console.WriteLine("Imię: " + Imie);
            Console.WriteLine("Nazwisko: " + Nazwisko);
            Console.WriteLine("Adres:");
            Console.WriteLine("Ulica: " + adresOsoby.Ulica);
            Console.WriteLine("Miasto: " + adresOsoby.Miasto);
            Console.WriteLine("Kod pocztowy: " + adresOsoby.KodPocztowy);
        }
    }
}