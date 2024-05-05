
/*Utwórz klasę Sprzedaz.
W klasie zdefiniuj pola reprezentujące nazwę produktu, ilość, cenę (sprzedaży).
Zaimplementuj konstruktor o sygnaturze: Sprzedaż(string p, int a, decimal sP)
Zaimplementuj metodę wypisującą informacje o sprzedaży na konsolę.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Labs._2._7;

public class Sprzedaz
{
    private readonly decimal cena;
    private readonly int ilosc;
    private readonly string nazwa;

    public Sprzedaz(string p, int a, decimal sP)
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