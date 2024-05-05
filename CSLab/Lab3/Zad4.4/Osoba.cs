namespace CSLab.Lab3.Zad4._4;

public class Osoba
{
    private int id;
    public string Imie;

    public string Nazwisko;
    protected int nrtel;

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }

    public override string ToString()
    {
        return Nazwisko + Imie;
    }
}