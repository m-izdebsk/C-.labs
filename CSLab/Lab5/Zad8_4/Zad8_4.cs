using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad8_4
{
    internal class Zad8_4
    {

        public void main(string[] args)
        {
            // Przykładowe użycie operatorów konwersji
            Produkt[] produkty = new Produkt[]
            {

            new Produkt("nazwa1",1,"kg",DateTime.Now,10f),
            new Produkt("nazwa2",2,"kg",DateTime.Now,10f),
            new Produkt("nazwa3",3,"kg",DateTime.Now,10f)
            };

            Zamowienie zamówienie = produkty; // Wykorzystanie niejawnego operatora konwersji

            // Obliczenie sumy zamówienia za pomocą jawnej konwersji
            double suma = (double)zamówienie;

            Console.WriteLine($"Suma zamówienia: {suma}"); // Wyświetli sumę cen produktów w zamówieniu
        }
    }
}
