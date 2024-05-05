using System.Diagnostics;

namespace CSLab.Lab3.Zad5_3
{
    internal class Zad5_3
    {
        internal void main(string[] args)
        {
            Osoba os = new Osoba("test1n0", "test1");
            Osoba os2 = new Osoba("test1n1", "test2");
            Osoba os3 = new Osoba("test1n2", "test3");
            Grupa grupa = new Grupa("test group");
            Grupa grupa2 = new Grupa("test group2");
            //dodanie 3 czlonkow
            grupa.dodajCzlonka(os);
            grupa.dodajCzlonka(os2);
            grupa.dodajCzlonka(os3);
            grupa2.dodajCzlonka(os);
            Debug.Assert(grupa.czyJestWieksza(grupa2));
            Debug.Assert(grupa.czyJestWiekszaLiczbaOsob(grupa2));
            
        }
    }
}
