
using System.Diagnostics;

namespace CSLab.Lab3.Zad4._3
{
    internal class Zad4_3
    {
        public void main(string[] args)
        {
            var t1 = new Transakcja(DateTime.Now.AddDays(-1), "Test title 1", 1);
            var osoba = new Osoba("test,", "nazwisko", 25.0f);
            Przelew przelew = new Przelew(DateTime.Now.AddDays(-10), "Test title 3", 3,"PL12311231123123");
            Console.WriteLine(przelew);
            var konto = new Konto("asdfadsf", osoba, DateTime.Now.AddDays(-100));
            konto.dodajTransackje(przelew);
            konto.WypiszInformacjeOKoncie();

        }
    }
}
