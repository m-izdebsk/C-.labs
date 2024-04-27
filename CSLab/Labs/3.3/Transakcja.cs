namespace CSLab.Labs._3._3
{

    class Transakcja
    {
        //atrybuty tytul, kwota, i data    
        private string tytul;
        private enum TransType;

        private decimal kwota;
        private DateTime dataRealizacjiTransakcji;

        //Zdefiniuj właściwość dającą publiczny dostęp do pola kwota (transakcji).
        public decimal getKwota()
        {
            return this.kwota;

        }

        // Konstruktor klasy Transakcja
        //Utwórz klasę Transakcja(w pliku ‘Transakcja.cs’). -done
        //W klasie zdefiniuj pola reprezentujące datę realizacji, tytuł(em), kwotę(ujemna będzie oznaczała obciążenie konta, dodatnia jego uznanie).-done
        //Zaimplementuj konstruktor klasy(przekazujący wartości do pól) oraz metodę wypisującą informacje o transakcji na konsolę. -done


        public Transakcja(DateTime dataRealizacji, string tytul, decimal kwota)
        {
            this.dataRealizacjiTransakcji = dataRealizacji;
            this.tytul = tytul;
            this.kwota = kwota;

        }

        //wypisanie info o transakcji
        public void wypiszNaKonsole()
        {
            Console.WriteLine("Data:" + dataRealizacjiTransakcji);
            Console.WriteLine("Tytuł:" + tytul);
            Console.WriteLine("Kwota:" + kwota);
            Console.WriteLine();
            Console.WriteLine();
        }
        //getter to get title
        public string getTytul()
        {
            return tytul;
        }
        //W klasie Transakcja zdefiniuj metodę public override string ToString(), która zwraca string z opisem danych transakcji.
        public override string ToString() {
            return "Tytul:"+tytul+":\nData:"+this.dataRealizacjiTransakcji+"\nKwota:"+this.getKwota();
        
        }
    }
}