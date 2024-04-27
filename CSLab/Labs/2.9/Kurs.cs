using CSLab.Labs._2._9;


namespace CSLab
{
    class Kurs
    {
        private string nazwaKursu;
        private int liczbaGodzin;
        private Osoba osoba; //korzystamy z klas osoba
        private Grupa[] grupa;
        // Konstruktor klasy "kurs"

        public Kurs(string nazwaKursu, int liczbaGodzin, Osoba wykladowca, Grupa[] grupaCwiczeniowa)
        {
            this.nazwaKursu = nazwaKursu;
            this.liczbaGodzin = liczbaGodzin;
            this.osoba = wykladowca;
            this.grupa = grupaCwiczeniowa;
        }

        // Metoda wypisująca dane kursu
        public void printData()
        {
            Console.WriteLine("Nazwa kursu: " + nazwaKursu);
            Console.WriteLine("Liczba godzin: " + liczbaGodzin);
            Console.WriteLine("Wykładowca: " + osoba.Imie + " " + osoba.Nazwisko);
            Console.WriteLine("Grupa ćwiczeniowa - wielkosc: " + grupa.Length);
        }
    }
}
