using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Utwórz klasę Sprzedaz.
W klasie zdefiniuj pola reprezentujące nazwę produktu, ilość, cenę (sprzedaży).
Zaimplementuj konstruktor o sygnaturze: Sprzedaż(string p, int a, decimal sP)
Zaimplementuj metodę wypisującą informacje o sprzedaży na konsolę.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Labs._2._7
{
    public class Sprzedaz
    {
        string nazwa;
        int ilosc;
        decimal cena;
        public Sprzedaz(string p, int a, decimal sP) {
            this.nazwa = p;
            this.ilosc = a;
            this.cena = sP;
        }

        public void printData() {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Nazwa:" + this.nazwa + "\nIlosc:" + this.ilosc + "\nCena:" + this.cena;
        }


    }
}
