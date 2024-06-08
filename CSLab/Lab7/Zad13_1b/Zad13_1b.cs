/*
 

Kolekcje generyczne

XIII.1. Kod bazowy z projektu generics_2
Przebuduj klasę Grupa tak, aby członkowie grupy byli przechowywani w:
    a. kolekcji typu List
    b. kolekcji typu SortedDictionary (kluczami niech będą nazwiska)


 */
using System.Diagnostics;

namespace CSLab.Lab7.Zad13_1b
{
    internal class Zad13_1b
    {
        public void main(string[] args) {
            var os = new Osoba("test1n0", "test1");
            var os2 = new Osoba("test1n1", "test2");
            var os3 = new Osoba("test1n2", "test3");
            var grupa = new Grupa("test group");
            var grupa2 = new Grupa("test group2");
            //dodanie 3 czlonkow
            grupa.DodajCzlonka(os);
            grupa.DodajCzlonka(os2);
            grupa.DodajCzlonka(os3);
            grupa2.DodajCzlonka(os);
            Debug.Assert(grupa.czyJestWieksza(grupa2));
            Debug.Assert(grupa.czyJestWiekszaLiczbaOsob(grupa2));
            Console.WriteLine(
                grupa.czyJestWieksza(grupa2));
            Console.WriteLine(
                grupa.czyJestWiekszaLiczbaOsob(grupa2));
            //sprawdzenie rozumaru grupy
            Debug.Assert(grupa.rozmiar == 3);
            grupa.usunCzlonka("test1");
            //Debug.Assert(grupa.rozmiar == 2);
            grupa.usunCzlonka("test1");
            Console.WriteLine(grupa.rozmiar);
            //Debug.Assert(grupa.rozmiar == 1);
        }
    }
}
