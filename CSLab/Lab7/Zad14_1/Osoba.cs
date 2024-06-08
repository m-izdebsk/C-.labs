namespace CSLab.Lab7.Zad14_1;

internal class Osoba
{
    public string Imie;

    public string Nazwisko;

    public int wzrost;

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        wzrost = 174;
    }

    public Osoba(string imie, string nazwisko, int wzrost)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        this.wzrost = wzrost;
    }


}