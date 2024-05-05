using System.Reflection;

/*
III.2 Kod bazowy w projekcie ‘produkt’
W klasie Produkt:
    a. Zdefiniuj właściwości dające publiczny dostęp do pól: nazwa produktu, jednostka miary i cena zakupu.
    b. Zdefiniuj właściwość CenaDetaliczna obliczająca cenę po której będzie sprzedawany produkt.
    c. Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]

*/
namespace CSLab.Labs._3._2;

public class Produkt2
{
    private readonly float cena;

    //Zdefiniuj właściwość CenaDetaliczna obliczająca cenę po której będzie sprzedawany produkt.
    private float cenaDetaliczna;
    private readonly DateTime dataZakupu;
    private readonly string jednostkaMiary;
    private readonly string nazwa;
    private readonly float VAT;


    public Produkt2(string nazwa, float cena, string jednostka, DateTime dataZakupu, float vat)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        jednostkaMiary = jednostka;
        this.dataZakupu = dataZakupu;
        VAT = vat;
        cenaDetaliczna = this.cena + this.cena * (VAT / 100);
    }

    //Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]
    public object this[string propertyName] => getValueByName(propertyName);

    private object getValueByName(string propertyName)
    {
        var fieldInfo = typeof(Produkt2).GetField(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
        if (fieldInfo != null)
            return fieldInfo.GetValue(this);
        throw new ArgumentException($"Wartosc '{propertyName}' nie istnieje");
    }

    public string getByName(string name)
    {
        var value = "";


        return value;
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

    public Produkt2 readDataFromKeyboard()
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
        return new Produkt2(nazwa, cena, jm, date, vat);
    }

    public Produkt2 clone()
    {
        return new Produkt2(nazwa, cena, jednostkaMiary, dataZakupu, VAT);
    }
}