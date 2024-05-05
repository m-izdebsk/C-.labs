using System.Diagnostics;

namespace CSLab.Labs._3._1;

internal class P3_1
{
    public void main(string[] args)
    {
        var imie = "JakiesImie";
        var nazwisko = "Nazwisko";
        var bmi = 35.0;
        //testing
        var osoba = new Osoba(imie, nazwisko, bmi);
        Debug.Assert(osoba != null);
        Debug.Assert(osoba.getImie() == imie);
        Debug.Assert(osoba.getNazwisko() == nazwisko);
        Debug.Assert(osoba.getBmi() == bmi);
    }
}