﻿
using System.Diagnostics;


namespace CSLab.Lab5.Zad9_1
{
    internal class Zad9_1
    {
        //Zdefiniuj delegację reprezentującą funkcje o dwóch argumentach typu string i int, zwracające wynik typu string.
        public delegate string MojaDelegacja(string tekst, int liczba);

        public void main(string[] args)
        {
            MojaDelegacja doklej = MetodyDelegacji.DoklejLiczbe;
            MojaDelegacja powtorz = MetodyDelegacji.PowtorzString;
            MojaDelegacja poczatekZnaki = MetodyDelegacji.PoczatkoweZnaki;
            string wynik = doklej("Tekst", 123);
            Debug.Assert(wynik == "Tekst123");
            Console.WriteLine(wynik);
            wynik = powtorz("Tekst", 3);
            Console.WriteLine(wynik);
            Debug.Assert(wynik == "TekstTekstTekst");
            wynik = poczatekZnaki("Tekst", 3);
            Console.WriteLine(wynik);
            Debug.Assert(wynik == "Tek");

            MojaDelegacja wszystkieMetody = MetodyDelegacji.DoklejLiczbe;
            wszystkieMetody += MetodyDelegacji.PowtorzString;
            wszystkieMetody += MetodyDelegacji.PoczatkoweZnaki;
            string all = wszystkieMetody("Tekst123", 2);
            Console.WriteLine(all);
            Debug.Assert(all == "Te");
        }


    }
    public class MetodyDelegacji
    {
        //metoda doklejająca liczbę na końcu stringa
        public static string DoklejLiczbe(string tekst, int liczba)
        {
            return tekst + liczba.ToString();
        }

        //metoda powtarzająca string tyle razy na ile wskazuje drugi argument
        public static string PowtorzString(string tekst, int liczba)
        {
            string item = "";
            for (int i = 0; i < liczba; i++)
            {
                item += tekst;
            }
            return item;
        }

        //metoda zwracająca początkowe znaki ze stringa (tyle ile wskazuje drugi argument)
        public static string PoczatkoweZnaki(string tekst, int liczba)
        {
            if (liczba >= tekst.Length)
                return tekst;
            else
                return tekst.Substring(0, liczba);
        }
    }


}
