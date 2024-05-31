
/*II.6 (nowy projekt ‘produkt’)
Utwórz klasę o nazwie Produkt.

Zaimplementuj konstruktor klasy (przekazujący wartości do pól) oraz metodę wypisującą dane produktu na konsolę.
Zaimplementuj konstruktor tworzący obiekt w oparciu o wartości podane z konsoli.
Zaimplementuj metodę Clone() tworzącą kopię obiektu.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Lab5.Zad8_4;

public class Produkt
{
    public readonly float cena;
    private readonly DateTime dataZakupu;
    private readonly string jednostkaMiary;
    public readonly string nazwa;
    private readonly float VAT;


    public Produkt(string nazwa, float cena, string jednostka, DateTime dataZakupu, float vat)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        jednostkaMiary = jednostka;
        this.dataZakupu = dataZakupu;
        VAT = vat;
    }

    public override string ToString()
    {
        return "Nazwa: " + nazwa + "\nCena:" + cena + "\nj.m.:" + jednostkaMiary + "\nData zakupu:" + dataZakupu +
               "\nVAT:" + VAT;
    }

    public void printData()
    {
        Console.WriteLine(this);
    }

    public Produkt readDataFromKeyboard()
    {
        Console.WriteLine("Podaj nazwe:");
        var nazwa = Console.ReadLine();

        Console.WriteLine("Podaj cene:");
        var cena = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj jednostke miary:");
        var jm = Console.ReadLine();

        Console.WriteLine("Podaj date zakupu w formacie: yyyy-MM-dd mm:HH:ss");
        var date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Podaj vat:");
        var vat = float.Parse(Console.ReadLine());
        return new Produkt(nazwa, cena, jm, date, vat);
    }

    public Produkt clone()
    {
        return new Produkt(nazwa, cena, jednostkaMiary, dataZakupu, VAT);
    }
}