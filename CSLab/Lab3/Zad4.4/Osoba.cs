namespace CSLab.Lab3.Zad4._4
{
    public class Osoba
    {
        public string Imie;
        protected int nrtel;
        private int id;

        public string Nazwisko;
        public Osoba(string imie, string nazwisko) {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return this.Nazwisko+this.Imie;
        }
    }
}
