
using System.Diagnostics;

namespace CSLab.Lab3.Zad4._2
{
    internal class Zad4_2
    {
        public void main(string[] args)
        {
            Produkt produkt = new Produkt("cukier", 9.4f, "kg", DateTime.Now, 23.0f);
            ProduktSpozywczy prod_spozywczy = new ProduktSpozywczy(produkt,DateTime.Now.AddDays(60),10f);
            DateTime przed = DateTime.Now.AddDays(40);
            DateTime po = DateTime.Now.AddDays(90);

            /*
            Napisz dwie wersje metody o nazwie doSpozycia(). Pierwsza nie przyjmuje żadnych parametrów i 
            zwraca true jeśli produkt jest na dzień dzisiejszy zdolny do spożycia. 
            Druga wersja przyjmuje parametr typu DateTime i zwraca true gdy produkt jest zdolny do spożycia w dniu podanym jako parametr.
            */
            Debug.Assert(prod_spozywczy.doSpozycia());
            Debug.Assert(prod_spozywczy.doSpozycia(przed));
            Debug.Assert(!prod_spozywczy.doSpozycia(po));
            /*Napisz metodę nadpisującą (wirtualnie) metodę klasy bazowej do wypisywania informacji o produkcie na konsoli. 
             Uzupełnij informację o wypisanie daty ważności do spożycia.*/
            Console.WriteLine(prod_spozywczy.ToString());



        }
    }
}
