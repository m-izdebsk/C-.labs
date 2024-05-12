namespace CSLab.Lab3.Zad4._5;

public class Osoba
{
    private static int id = 1;
    public string Imie;

    public string Nazwisko;
    private int nrtel;

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        id++;
    }
    internal int getId()
    {
        return id;
            }
    public override string ToString()
    {
        return "Imie:" + this.Imie + "\nNazwisko:" + this.Nazwisko + "\nNr tel:" + this.nrtel+"\nID:"+id;
    }
}