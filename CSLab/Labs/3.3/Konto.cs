using System;

namespace CSLab.Labs._3._3
{

    class Konto
    {
        // Pola reprezentujące numer konta, nazwę właściciela oraz datę utworzenia
        private string numerKonta;
        private Osoba wlasciciel;
        private DateTime dataUtworzenia;

        // Pole przechowujące transakcje (ostatnie 500 uznających, ostatnie 1000 obciążających)
        private Transakcja[,] transakcje = new Transakcja[2, 1000]; // 2 wiersze: uznania i obciążenia
        private int uznania=0;
        private int obciazenia=0;

        // Konstruktor klasy Konto
        public Konto(string numerKonta, Osoba wlasciciel, DateTime dataUtworzenia)
        {
            this.numerKonta = numerKonta;
            this.wlasciciel = wlasciciel;
            this.dataUtworzenia = dataUtworzenia;
        }

        // Metoda wypisująca informacje o koncie na konsolę
        public void WypiszInformacjeOKoncie()
        {
            Console.WriteLine($"Numer konta: {numerKonta}");
            Console.WriteLine($"Właściciel: {wlasciciel}");
            Console.WriteLine($"Data utworzenia: {dataUtworzenia}");
        }

        // Metoda ToString zwracająca informacje o koncie
        public override string ToString()
        {
            return $"Numer konta: {numerKonta}\nWłaściciel: {wlasciciel}\nData utworzenia: {dataUtworzenia}";
        }
        //Dodaj do klasy Konto właściwość Saldo obliczającą saldo konta.
        public decimal getSaldo() {
            decimal saldo = 0;
            
            for (int i = 0; i < uznania; i++) {
                saldo += this.transakcje[0, i].getKwota();
            }
            for (int i = 0; i < obciazenia; i++) {
                saldo += this.transakcje[1, i].getKwota();
            }
            return saldo;
        }

        //Dodaj do klasy metody uznajKonto(Transakcja t) oraz obciazKonto(Transakcja t), które będą dodawać do transakcji konta transakcję uznania lub transakcję obciążenia.
        public void uznajKonto(Transakcja t) { dodajTransackje(t); }
        //Dodaj do klasy metody uznajKonto(Transakcja t) oraz obciazKonto(Transakcja t), które będą dodawać do transakcji konta transakcję uznania lub transakcję obciążenia.
        public void obciazKonto(Transakcja t) { dodajTransackje(t); }
        public void dodajTransackje(Transakcja transakcja) {
            if (transakcja.getKwota() > 0)
            {
                this.transakcje[0,uznania] = transakcja;
                uznania++;
            }
            else {
                this.transakcje[1, obciazenia] = transakcja;
                obciazenia++;
            }
            transakcja.wypiszNaKonsole();
        }
 
    }
}
