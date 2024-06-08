namespace CSLab.Lab7.Zad13_1a;

internal class Kurs
{
    private readonly Narzedzia.Zad2.Grupa[] grupa;
    private readonly int liczbaGodzin;
    private readonly string nazwaKursu;

    private readonly Osoba osoba; //korzystamy z klas osoba
    // Konstruktor klasy "kurs"

    public Kurs(string nazwaKursu, int liczbaGodzin, Osoba wykladowca, Narzedzia.Zad2.Grupa[] grupaCwiczeniowa)
    {
        this.nazwaKursu = nazwaKursu;
        this.liczbaGodzin = liczbaGodzin;
        osoba = wykladowca;
        grupa = grupaCwiczeniowa;
    }

    // Metoda wypisująca dane kursu
    public void printData()
    {
        Console.WriteLine("Nazwa kursu: " + nazwaKursu);
        Console.WriteLine("Liczba godzin: " + liczbaGodzin);
        Console.WriteLine("Wykładowca: " + osoba.Imie + " " + osoba.Nazwisko);
        Console.WriteLine("Grupa ćwiczeniowa - wielkosc: " + grupa.Length);
    }
}