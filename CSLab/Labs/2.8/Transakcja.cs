namespace CSLab;

internal class Transakcja
{
    private readonly DateTime dataRealizacjiTransakcji;

    private readonly decimal kwota;

    //atrybuty tytul, kwota, i data    
    private readonly string tytul;

    // Konstruktor klasy Transakcja
    //Utwórz klasę Transakcja(w pliku ‘Transakcja.cs’). -done
    //W klasie zdefiniuj pola reprezentujące datę realizacji, tytuł(em), kwotę(ujemna będzie oznaczała obciążenie konta, dodatnia jego uznanie).-done
    //Zaimplementuj konstruktor klasy(przekazujący wartości do pól) oraz metodę wypisującą informacje o transakcji na konsolę. -done


    public Transakcja(DateTime dataRealizacji, string tytul, decimal kwota)
    {
        dataRealizacjiTransakcji = dataRealizacji;
        this.tytul = tytul;
        this.kwota = kwota;
    }

    //getter to get kwota
    public decimal getKwota()
    {
        return kwota;
    }

    //wypisanie info o transakcji
    public void wypiszNaKonsole()
    {
        Console.WriteLine("Data:" + dataRealizacjiTransakcji);
        Console.WriteLine("Tytuł:" + tytul);
        Console.WriteLine("Kwota:" + kwota);
        Console.WriteLine();
        Console.WriteLine();
    }

    //getter to get title
    public string getTytul()
    {
        return tytul;
    }

    private enum TransType;
}