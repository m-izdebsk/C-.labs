using CSLab.Labs._2._12;

namespace CSLab;

/*W klasie Sprzedaz zmień typ pola reprezentującego nazwę produktu (dotychczas string) na Produkt (wykorzystaj klasę Produkt zdefiniowaną w innym projekcie – zadaniu II.6). Wykonaj niezbędne korekty w konstruktorach i metodach klasy, aby zachować poprawność działania.
W klasie Zamowienie zmień typ pola reprezentującego klienta (dotychczas string) na Osoba (zdefiniowaną w innym projekcie).
Wykonaj niezbędne korekty w konstruktorach i metodach klasy, aby zachować poprawność działania. Przetestuj.O
*/
internal class P2_12
{
    public void main(string[] args)
    {
        var osoba2 = new Osoba2("test", "nazwisko");
        var produkt = new Produkt2("cukier", 1.43f, "kg", DateTime.Now, 23);
        var sp = new Sprzedaz2(produkt, 10, 10);
        var zam = new Zamowienie2(DateTime.Now, osoba2.Imie + osoba2.Nazwisko);
        zam.DodajPozycje(sp);
        zam.info();
    }
}