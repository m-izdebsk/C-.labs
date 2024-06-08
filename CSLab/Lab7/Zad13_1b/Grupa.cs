namespace CSLab.Lab7.Zad13_1b;

internal class Grupa
{
    public SortedDictionary<string, Osoba> czlonkowie { get; private set; } = new SortedDictionary<string, Osoba>();
    public string Nazwa { get; set; }
    public int rozmiar => czlonkowie.Count;


    public Grupa(string nazwa)
    {
        Nazwa = nazwa;
    }

    public bool czyJestWieksza(Grupa grupa)
    {
        return rozmiar > grupa.rozmiar;
    }

    public bool czyJestWiekszaLiczbaOsob(Grupa grupa)
    {
        return czlonkowie.Count > grupa.czlonkowie.Count;
    }

    public void DodajCzlonka(Osoba osoba)
    {
        czlonkowie[osoba.Nazwisko] = osoba;
    }

    public void usunCzlonka(string nazwisko)
    {
        czlonkowie.Remove(nazwisko);
    }

}