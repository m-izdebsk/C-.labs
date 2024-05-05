using System.Diagnostics;
using CSLab.Labs._2._6;

/*
 *
II.6 (nowy projekt ‘produkt’)
Utwórz klasę o nazwie Produkt.
W klasie zdefiniuj pola reprezentujące nazwę, cenę zakupu, jednostkę miary, datę zakupu, stawkę VAT, marżę (zysku).
Zaimplementuj konstruktor klasy (przekazujący wartości do pól) oraz metodę wypisującą dane produktu na konsolę.
Zaimplementuj konstruktor tworzący obiekt w oparciu o wartości podane z konsoli.
Zaimplementuj metodę Clone() tworzącą kopię obiektu.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().

 */
namespace CSLab;

internal class P2_6
{
    public void main(string[] args)
    {
        var produkt = new Produkt("cukier", 9.4f, "kg", DateTime.Now, 23.0f);
        Console.WriteLine(produkt);
        produkt.printData();
        Console.WriteLine(produkt.clone);
        Debug.Assert(produkt != produkt.clone());
    }
}