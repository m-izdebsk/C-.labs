namespace CSLab.Zad2._3;

public delegate void WypiszDelegate2();
internal class Grupa
{
    private List<Osoba> osoby;
    private WypiszDelegate2 _metodaWypisywania;

    public void dodajOsobe(Osoba os) {
        osoby.Add(os);
    }
    public void Sort(ComparisonDelegate compare, SortAlgorithmDelegate sortAlgorithm)
    {
        sortAlgorithm(osoby, compare);
    }
    public Grupa() {
        osoby = new List<Osoba>();

    }
    public Grupa(WypiszDelegate2 metodaWypisywania):base()
    {        
        _metodaWypisywania = metodaWypisywania;
    }
    public void zmienWypisywania(WypiszDelegate2 metodaWypisywania)
    {
        this._metodaWypisywania = metodaWypisywania;
    }
    public static void wypisz1()
    {
        Console.WriteLine("1") ;
    }
    public static void wypisz2() {
        Console.WriteLine(  "2");
    }
    public static void wypisz3() {
        Console.WriteLine("3");
    }
    public void Wypisz()
    {
        _metodaWypisywania();
    }
    public void wypiszosoby()
    {
        foreach (Osoba osoba in osoby)
        {
            Console.WriteLine($"{osoba.Imie} {osoba.Nazwisko}");
        }
    }

    // Przykładowy algorytm sortowania: sortowanie przez wstawianie
    public static void InsertSort(List<Osoba> osoby, ComparisonDelegate compare)
    {
        for (int i = 1; i < osoby.Count; i++)
        {
            var key = osoby[i];
            int j = i - 1;
            while (j >= 0 && compare(osoby[j], key) > 0)
            {
                osoby[j + 1] = osoby[j];
                j--;
            }
            osoby[j + 1] = key;
        }
    }

    // Przykładowy algorytm sortowania: sortowanie bąbelkowe
    public static void BubbleSort(List<Osoba> osoby, ComparisonDelegate compare)
    {
        int n = osoby.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (compare(osoby[j], osoby[j + 1]) > 0)
                {
                    var temp = osoby[j];
                    osoby[j] = osoby[j + 1];
                    osoby[j + 1] = temp;
                }
            }
        }
    }



}
