namespace CSLab;
//Przetestuj działanie obiektów klasy Konto pisząc odpowiedni kod testowy w metodzie Main() (zdefiniowanej w pliku ‘Program.cs’).

internal class P2_8
{
    public void main(string[] args)
    {
        var t1 = new Transakcja(DateTime.Now.AddDays(-1), "Test title 1", 1);
        var t2 = new Transakcja(DateTime.Now.AddDays(-40), "Test title 2", 2);
        var t3 = new Transakcja(DateTime.Now.AddDays(-10), "Test title 3", 3);
        var t4 = new Transakcja(DateTime.Now.AddDays(-100), "Test title 4", 4);
        var t11 = new Transakcja(DateTime.Now.AddDays(-12), "Test title 1", -1);
        var t22 = new Transakcja(DateTime.Now.AddDays(-12), "Test title 2", -2);
        var t33 = new Transakcja(DateTime.Now.AddDays(-22), "Test title 3", -3);
        var t44 = new Transakcja(DateTime.Now.AddDays(-100), "Test title 4", -4);
        var konto = new Konto("asdfadsf", "Test user", DateTime.Now.AddDays(-100));
        konto.WypiszInformacjeOKoncie();
        t1.wypiszNaKonsole();

        konto.dodajTransackje(t1);
        konto.dodajTransackje(t2);
        konto.dodajTransackje(t3);
        konto.dodajTransackje(t4);
        konto.dodajTransackje(t11);
        konto.dodajTransackje(t22);
        konto.dodajTransackje(t33);
        konto.dodajTransackje(t44);
    }
}