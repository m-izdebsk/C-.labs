namespace CSLab.Lab3.Zad4._4;

public class Pracownik :Osoba
{
    private readonly int nrtelefonu;

    public Pracownik(string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        
    }  public Pracownik(string imie, string nazwisko,int nr_tel) : base(imie, nazwisko)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.nrtelefonu = nr_tel;

    }

    public override string ToString()
    {
        return base.ToString()+this.nrtelefonu;
    }

  
}