using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Zad2._1;

internal class Spr2_1
{
    public void main(string[] args)
    {
        var osoba2 = new Osoba2("test", "nazwisko");
        var produkt = new Produkt2("cukier", 1.43f, "kg", DateTime.Now, 23);
        var sp = new Sprzedaz2(produkt, 10, 10);
        var zam = new Zamowienie2(DateTime.Now, osoba2.Imie + osoba2.Nazwisko);
        zam.DodajPozycje(sp);
        zam.info();

        decimal wartośćZamówienia = (decimal)zam;
        Console.WriteLine(wartośćZamówienia); // Wyświetli sumaryczną wartość zamówienia

        /*Kod bazowy w projekcie ‘zamowienie’
a. Zdefiniuj operator jawnej konwersji z typu Zamówienie do liczby typu decimal. Wynikiem konwersji powinna być sumaryczna wartość zamówienia.

b. Zaimplementuj niejawną konwersję tablicy obiektów typu Produkt do obiektu typu Zamówienie. Produkty z tablicy powinny stać się pozycjami zamówienia (jako obiekty klasy Sprzedaż), każdy z ilością równą jeden.
        */

        Produkt2[] produkty = new Produkt2[]
{
    new Produkt2("cukier",100,"kg",DateTime.Now,22),
    new Produkt2("cukier",100,"kg",DateTime.Now,22),
    
};

        Zamowienie2 zamówienie = produkty;
        zamówienie.info();

        

    }
}
