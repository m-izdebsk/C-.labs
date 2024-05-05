namespace CSLab.Labs._2._7;

internal class P2_7
{
    //Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().

    public void main(string[] args)
    {
        var s1 = new Sprzedaz("Auto", 2, new decimal(13123.25));
        var s2 = new Sprzedaz("Cukier", 2, new decimal(10.25));
        var s3 = new Sprzedaz("Ryba", 2, new decimal(2.25));
        var z = new Zamowienie(DateTime.Now, "Google");
        z.DodajPozycje(s1);
        z.DodajPozycje(s2);
        z.DodajPozycje(s3);
        s1.printData();
        z.info();
    }
}