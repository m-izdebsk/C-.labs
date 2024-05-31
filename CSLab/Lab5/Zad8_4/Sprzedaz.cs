

/*Utwórz klasę Sprzedaz.
W klasie zdefiniuj pola reprezentujące nazwę produktu, ilość, cenę (sprzedaży).
Zaimplementuj konstruktor o sygnaturze: Sprzedaż(string p, int a, decimal sP)
Zaimplementuj metodę wypisującą informacje o sprzedaży na konsolę.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Lab5.Zad8_4;

public class Sprzedaz
{
    public readonly double cena;

    public readonly int ilosc;
    //W klasie Sprzedaz zmień typ pola reprezentującego nazwę produktu (dotychczas string) na Produkt (wykorzystaj klasę Produkt zdefiniowaną w innym projekcie – zadaniu II.6).

    readonly Produkt nazwa;

    public Sprzedaz(Produkt p, int a, double sP)
    {
        nazwa = p;
        ilosc = a;
        cena = sP;
    }

    public void printData()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return "Nazwa:" + nazwa + "\nIlosc:" + ilosc + "\nCena:" + cena;
    }
}