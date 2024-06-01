
/*

Utwórz klasę Zamowienie.
W klasie zdefiniuj pola reprezentujące datę realizacji, nazwę klienta, pozycje zamównienia (jako tablicę obiektów klasy Sprzedaz,
zakładając obecność maksymalnie 20-stu pozycji w jednym zamówieniu).
Zaimplementuj konstruktor, który przekazuje datę i kupującego oraz przydziela pamięć dla tablicy pozycji zamówienia.
Zaimplementuj metodę dodajPozycje() dodającą do zamówienia kolejną pozycję. Zaimplementuj dwie postaci tej metody:
dodajPozycje(Sprzedaz pozycja) oraz dodajPozycje(string p, int a, decimal sP).
Zaimplementuj metodę wypisującą informacje o zamówieniu (w tym informacje o wszystkich pozycjach tego zamówienia) na konsoli.

*/
namespace CSLab.Zad2._1;
public class Zamowienie2
{
    private int _counter;
    private readonly DateTime dataRealizacji;
    private readonly Osoba2 nazwaKlienta;
    private readonly Sprzedaz2[] pozycjeZamowienia;

    public Zamowienie2(DateTime data, string klient)
    {
        dataRealizacji = data;
        nazwaKlienta = new Osoba2(klient, klient);
        pozycjeZamowienia = new Sprzedaz2[20];
    }

    public Zamowienie2()
    {
        _counter = 0;
        dataRealizacji = DateTime.Now;
        pozycjeZamowienia = new Sprzedaz2[20];

    }

    public void DodajPozycje(Sprzedaz2 pozycja)
    {
        if (_counter == 20)
        {
            Console.WriteLine("Nie można dodać więcej pozycji!");
            return;
        }

        pozycjeZamowienia[_counter++] = pozycja;
    }

    public void DodajPozycje(string p, int a, decimal sP)
    {
        if (_counter == 20)
        {
            Console.WriteLine("Nie można dodać więcej pozycji!");
            return;
        }

        var produkt = new Produkt2(p, 1.0f, "kg", DateTime.Now, 24);
        pozycjeZamowienia[_counter++] = new Sprzedaz2(produkt, a, sP);
    }

    public void info()
    {
        Console.WriteLine($"Data realizacji: {dataRealizacji}");
        Console.WriteLine($"Nazwa klienta: {nazwaKlienta}");

        for (var i = 0; i < _counter; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Pozycja nr {i + 1}");
            pozycjeZamowienia[i].printData();
            Console.WriteLine();
        }
    }
    /*
     Kod bazowy w projekcie ‘zamowienie’
a. Zdefiniuj operator jawnej konwersji z typu Zamówienie do liczby typu decimal. Wynikiem konwersji powinna być sumaryczna wartość zamówienia.

b. Zaimplementuj niejawną konwersję tablicy obiektów typu Produkt do obiektu typu Zamówienie. Produkty z tablicy powinny stać się pozycjami zamówienia (jako obiekty klasy Sprzedaż), każdy z ilością równą jeden.
    */
    public static explicit operator decimal(Zamowienie2 zamówienie)
    {
        decimal suma = 0;
        foreach (Sprzedaz2 sprzedaz in zamówienie.pozycjeZamowienia)
        {
            if (sprzedaz != null) { 
                suma = suma+ sprzedaz.cena*sprzedaz.ilosc;
            }
        };
        return suma;
    }
    public static implicit operator Zamowienie2(Produkt2[] produkty)
    {
        Zamowienie2 zamówienie = new Zamowienie2();
        foreach (var produkt in produkty)
        {
            zamówienie.DodajPozycje(new Sprzedaz2(produkt, 1, 1));
        }
        return zamówienie;
    }
}