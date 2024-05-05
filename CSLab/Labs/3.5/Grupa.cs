namespace CSLab.Labs._3._5;

internal class Grupa
{
    public string Nazwa;

    public Grupa(string nazwa)
    {
        Nazwa = nazwa;
    }

//tak wygladalby indeksator.
    public string this[int indeksCzlonka, string nazwaCechy] => "niestety polecenie nie jest precyzyjne";
}