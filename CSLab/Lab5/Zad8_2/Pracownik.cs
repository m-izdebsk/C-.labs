
namespace CSLab.Lab5.Zad8_2
{
    internal class Pracownik : Osoba
    {
        public Pracownik(string imie, string nazwisko) : base(imie, nazwisko)
        {
            

        }
        public static implicit operator Student(Pracownik pracownik)
        {
            return new Student(pracownik.Imie, pracownik.Nazwisko);
        }

    }
}
