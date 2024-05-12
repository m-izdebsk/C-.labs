namespace CSLab.Lab3.Zad4._2
{
    /*Utwórz klasę ProduktSpozywczy dziedziczącą po klasie Produkt.
Klasa powinna posiadać pola reprezentujące datę ważności (termin przydatności do spożycia w dniach) 
    i wagę (poza polami dostępnymi z klasy bazowej). 
Zdefiniuj konstruktor przekazujący (poprzez parametry) wartości do pól obiektu (zarówno dziedziczonych jak i własnych). Skorzystaj z konstruktora klasy bazowej.
Zdefiniuj konstruktor (Produkt, DateTime, float). 
Uwaga: W celu eleganckiego rozwiązania tego zadania w klasie Produkt powinien być zdefiniowany konstruktor „kopiujący” postaci Produkt(Produkt p).

Napisz dwie wersje metody o nazwie doSpozycia(). Pierwsza nie przyjmuje żadnych parametrów i zwraca true jeśli produkt jest na dzień dzisiejszy zdolny do spożycia. Druga wersja przyjmuje parametr typu DateTime i zwraca true gdy produkt jest zdolny do spożycia w dniu podanym jako parametr.
Napisz metodę nadpisującą (wirtualnie) metodę klasy bazowej do wypisywania informacji o produkcie na konsoli. Uzupełnij informację o wypisanie daty ważności do spożycia.
    */
    internal class ProduktSpozywczy : Produkt
    {
        float waga;
        DateTime dataSpozycia;
        public ProduktSpozywczy(string nazwa, float cena, string jednostka, DateTime dataZakupu, float vat, float waga,int dniDoSpozycia) : base(nazwa, cena, jednostka, dataZakupu, vat)
        {
            this.waga = waga;
            this.dataSpozycia = DateTime.Now.AddDays(dniDoSpozycia);
        }
        public ProduktSpozywczy(Produkt produkt, DateTime dataSpozycia, float waga):base(produkt)
        {
            this.dataSpozycia = dataSpozycia;
            this.waga = waga;
        }


        public Boolean doSpozycia() {
            return DateTime.Now < this.dataSpozycia;            
        }
        public Boolean doSpozycia(DateTime date) {
            return date < this.dataSpozycia;
        }
        public override string ToString()
        {
            return base.ToString()+"\nData do spozycia"+this.dataSpozycia;
        }
    }
}
