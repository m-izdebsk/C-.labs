namespace CSLab;

internal class Konto
{
    private readonly DateTime dataUtworzenia;

    // Pola reprezentujące numer konta, nazwę właściciela oraz datę utworzenia
    private readonly string numerKonta;
    private int obciazenia;

    // Pole przechowujące transakcje (ostatnie 500 uznających, ostatnie 1000 obciążających)
    private readonly Transakcja[,] transakcje = new Transakcja[2, 1000]; // 2 wiersze: uznania i obciążenia
    private int uznania;
    private readonly string wlasciciel;

    // Konstruktor klasy Konto
    public Konto(string numerKonta, string wlasciciel, DateTime dataUtworzenia)
    {
        this.numerKonta = numerKonta;
        this.wlasciciel = wlasciciel;
        this.dataUtworzenia = dataUtworzenia;
    }

    // Metoda wypisująca informacje o koncie na konsolę
    public void WypiszInformacjeOKoncie()
    {
        Console.WriteLine($"Numer konta: {numerKonta}");
        Console.WriteLine($"Właściciel: {wlasciciel}");
        Console.WriteLine($"Data utworzenia: {dataUtworzenia}");
    }

    // Metoda ToString zwracająca informacje o koncie
    public override string ToString()
    {
        return $"Numer konta: {numerKonta}\nWłaściciel: {wlasciciel}\nData utworzenia: {dataUtworzenia}";
    }

    public void dodajTransackje(Transakcja transakcja)
    {
        if (transakcja.getKwota() > 0)
        {
            transakcje[0, uznania] = transakcja;
            uznania++;
        }
        else
        {
            transakcje[1, obciazenia] = transakcja;
            obciazenia++;
        }

        transakcja.wypiszNaKonsole();
    }
}