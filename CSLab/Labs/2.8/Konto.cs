using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._2._8
{

    class Konto
    {
        // Pola reprezentujące numer konta, nazwę właściciela oraz datę utworzenia
        private string numerKonta;
        private string wlasciciel;
        private DateTime dataUtworzenia;

        // Pole przechowujące transakcje (ostatnie 500 uznających, ostatnie 1000 obciążających)
        private Transakcja[,] transakcje = new Transakcja[2, 1000]; // 2 wiersze: uznania i obciążenia
        private int uznania=0;
        private int obciazenia=0;

        // Konstruktor klasy Konto
        public Konto(string numerKonta, string wlasciciel, DateTime dataUtworzenia)
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
