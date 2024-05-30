
namespace CSLab.Lab5.Zad8_2
{
    internal class Student : Osoba
    {
        public Student(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }
        public static explicit operator Pracownik(Student s)
        {
            return new Pracownik(s.Imie, s.Nazwisko);
        }
    }
}
