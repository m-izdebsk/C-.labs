namespace CSLab.Lab3.Zad5_3
{
    class Grupa
    {
        public string Nazwa;
        public int rozmiar;
        public Osoba[] czlonkowie = new Osoba[0];

        public bool czyJestWieksza(Grupa grupa)
        {
            return this.rozmiar > grupa.rozmiar;
        }
        public bool czyJestWiekszaLiczbaOsob(Grupa grupa)
        {
            return this.czlonkowie.Length > grupa.czlonkowie.Length;
        }
        

        public Grupa(string nazwa)
        {
            Nazwa = nazwa;
            rozmiar = 0;
        }
        public void dodajCzlonka(Osoba czlonek)
        {
            Osoba[] destinationArray = new Osoba[czlonkowie.Length + 1];
            Array.Copy(czlonkowie, destinationArray, czlonkowie.Length);
            destinationArray[czlonkowie.Length] = czlonek;
            czlonkowie = destinationArray;
            Console.WriteLine(czlonkowie.Length);
            rozmiar++;
        }
        public void usunCzlonka(Osoba czlonek)
        {

            for (int i = 0; i < czlonkowie.Length; i++)
            {
                if (czlonkowie[i] == czlonek)
                {
                    usunCzlonka(i);
                }
            }
        }public void usunCzlonka(string nazwisko)
        {
            for (int i = 0; i < czlonkowie.Length; i++)
            {
                if (czlonkowie[i].Nazwisko == nazwisko)
                {
                    czlonkowie[i] = null;
                    usunCzlonka(i);
                    break;
                }

                
            }
        }
        public void usunCzlonka(int czlonek)
        {
            if (czlonek < czlonkowie.Length)
            {
                Osoba removed = czlonkowie[czlonek];
                //przesun czlonka
                for (int i = czlonek; i < czlonkowie.Length; i++)
                {
                    czlonkowie[i - 1] = czlonkowie[i];
                }

            }


        }

    }
}
