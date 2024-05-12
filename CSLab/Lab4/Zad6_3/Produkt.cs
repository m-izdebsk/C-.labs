
using CSLab.Lab4.Zad6_3;

internal class Produkt
{
    private readonly float cena;
    private readonly DateTime dataZakupu;
    private readonly string jednostkaMiary;
    private readonly string nazwa;
    private readonly float VAT;
    private readonly Opakowanie opakowanie;


    public Produkt(float cena, DateTime dataZakupu, string jm, string nazwa, float vat, Opakowanie opakowanie = default)
    {
        this.cena = cena;
        this.dataZakupu = dataZakupu;
        this.jednostkaMiary = jm;
        this.nazwa= nazwa;
        this.VAT = vat;
        this.opakowanie = opakowanie;
        
        
    }

    public override string ToString()
    {
        return "Nazwa: " + nazwa + "\nCena:" + cena + "\nj.m.:" + jednostkaMiary + "\nData zakupu:" + dataZakupu +
               "\nVAT:" + VAT;
    }

}
