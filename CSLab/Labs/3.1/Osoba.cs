namespace CSLab.Labs._3._1;

/*
III.1.  Kod bazowy w projekcie klasy 2_1
    a. Oznacz pola imie i nazwisko z klasy Osoba jako prywatne zapewniając do nich publiczny dostęp poprzez odpowiednie właściwości.
    b. Dodaj do klasy właściwość ‘Bmi’, która będzie podawać wartość wskaźnika BMI danej osoby.*/
internal class Osoba
{
    private readonly double Bmi;
    private readonly string Imie;
    private readonly string Nazwisko;

    public Osoba(string imie, string nazwisko, double Bmi)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        this.Bmi = Bmi;
    }

    public string getImie()
    {
        return Imie;
    }

    public string getNazwisko()
    {
        return Nazwisko;
    }

    internal double getBmi()
    {
        return Bmi;
    }
}