namespace CSLab.Lab7.Zad13_1a;

internal class Grupa
{
    public List<Osoba> czlonkowie { get; private set; } = new List<Osoba>();

    public string Nazwa;
    public int rozmiar;


    public Grupa(string nazwa)
    {
        Nazwa = nazwa;
        rozmiar = 0;
    }

    public bool czyJestWieksza(Grupa grupa)
    {
        return rozmiar > grupa.rozmiar;
    }

    public bool czyJestWiekszaLiczbaOsob(Grupa grupa)
    {
        return czlonkowie.Count > grupa.czlonkowie.Count;
    }

    public void dodajCzlonka(Osoba czlonek)
    {
        czlonkowie.Add(czlonek);
        rozmiar++;
    }

    public void usunCzlonka(Osoba czlonek)
    {
        for (var i = 0; i < czlonkowie.Count; i++)
            if (czlonkowie[i] == czlonek)
                usunCzlonka(i);
    }

    public void usunCzlonka(string nazwisko)
    {
        for (var i = 0; i < czlonkowie.Count; i++)
            if (czlonkowie[i].Nazwisko == nazwisko)
            {
                czlonkowie[i] = null;
                usunCzlonka(i);
                break;
            }
    }

    public void usunCzlonka(int czlonek)
    {
        if (czlonek < czlonkowie.Count)
        {
            var removed = czlonkowie[czlonek];
            //przesun czlonka
            for (var i = czlonek; i < czlonkowie.Count; i++) czlonkowie[i - 1] = czlonkowie[i];
        }
    }
}