

/*Utwórz klasę Sprzedaz.
W klasie zdefiniuj pola reprezentujące nazwę produktu, ilość, cenę (sprzedaży).
Zaimplementuj konstruktor o sygnaturze: Sprzedaż(string p, int a, decimal sP)
Zaimplementuj metodę wypisującą informacje o sprzedaży na konsolę.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Labs._2._12;

public class Sprzedaz2
{
    private readonly decimal cena;

    private readonly int ilosc;
    //W klasie Sprzedaz zmień typ pola reprezentującego nazwę produktu (dotychczas string) na Produkt (wykorzystaj klasę Produkt zdefiniowaną w innym projekcie – zadaniu II.6).

    private readonly Produkt2 nazwa;

    public Sprzedaz2(Produkt2 p, int a, decimal sP)
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