namespace CSLab.Lab3.Zad4._3;

internal class Konto
{
    private readonly DateTime dataUtworzenia;

    // Pola reprezentujące numer konta, nazwę właściciela oraz datę utworzenia
    private readonly string numerKonta;
    private int obciazenia;

    // Pole przechowujące transakcje (ostatnie 500 uznających, ostatnie 1000 obciążających)
    private readonly Transakcja[,] transakcje = new Transakcja[2, 1000]; // 2 wiersze: uznania i obciążenia
    private int uznania;
    private readonly Osoba wlasciciel;

    // Konstruktor klasy Konto
    public Konto(string numerKonta, Osoba wlasciciel, DateTime dataUtworzenia)
    {
        this.numerKonta = numerKonta;
        this.wlasciciel = wlasciciel;
        this.dataUtworzenia = dataUtworzenia;
    }

    //Zdefiniuj indeksator, który umożliwi dostęp do transakcji wykonanych
    //na koncie za pomocą zapisu: konto1[‘uznania’][12] –
    //oznacza dostęp do 12-stej transakcji uznającej (wpływu na konto) dla konta konto1.

    public Transakcja[] this[string rodzajTransakcji]
    {
        get
        {
            var rowIndex =
                rodzajTransakcji == "uznania" ? 0 : 1; // Określenie indeksu wiersza na podstawie rodzaju transakcji
            var row = new Transakcja[transakcje.GetLength(1)];

            for (var i = 0; i < transakcje.GetLength(1); i++) row[i] = transakcje[rowIndex, i];

            return row;
        }
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

    //Dodaj do klasy Konto właściwość Saldo obliczającą saldo konta.
    public decimal getSaldo()
    {
        decimal saldo = 0;

        for (var i = 0; i < uznania; i++) saldo += transakcje[0, i].getKwota();
        for (var i = 0; i < obciazenia; i++) saldo += transakcje[1, i].getKwota();
        return saldo;
    }

    //Dodaj do klasy metody uznajKonto(Transakcja t) oraz obciazKonto(Transakcja t), które będą dodawać do transakcji konta transakcję uznania lub transakcję obciążenia.
    public void uznajKonto(Transakcja t)
    {
        dodajTransackje(t);
    }

    //Dodaj do klasy metody uznajKonto(Transakcja t) oraz obciazKonto(Transakcja t), które będą dodawać do transakcji konta transakcję uznania lub transakcję obciążenia.
    public void obciazKonto(Transakcja t)
    {
        dodajTransackje(t);
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