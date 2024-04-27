using CSLab.Labs._2._6;

/*Utwórz klasę Sprzedaz.
W klasie zdefiniuj pola reprezentujące nazwę produktu, ilość, cenę (sprzedaży).
Zaimplementuj konstruktor o sygnaturze: Sprzedaż(string p, int a, decimal sP)
Zaimplementuj metodę wypisującą informacje o sprzedaży na konsolę.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Labs._2._12
{
    public class Sprzedaz2
    {
        //W klasie Sprzedaz zmień typ pola reprezentującego nazwę produktu (dotychczas string) na Produkt (wykorzystaj klasę Produkt zdefiniowaną w innym projekcie – zadaniu II.6).

        Produkt2 nazwa;
        int ilosc;
        decimal cena;
        public Sprzedaz2(Produkt2 p, int a, decimal sP) {
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
