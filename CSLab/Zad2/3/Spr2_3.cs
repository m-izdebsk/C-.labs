

namespace CSLab.Zad2._3
{
    internal class Spr2_3
    {
        public static int CompareImie(Osoba o1, Osoba o2)
        {
            return string.Compare(o1.Imie, o2.Imie);
        }

        public static int CompareNazwisko(Osoba o1, Osoba o2)
        {
            return string.Compare(o1.Nazwisko, o2.Nazwisko);
        }

        public void main(string[] args) {
            var grupa = new Grupa();
            grupa.dodajOsobe(new Osoba("Anna","Kowalska"));
            grupa.dodajOsobe(new Osoba("Marius","Kowalski"));
            Console.WriteLine("Sortowanie według imienia (InsertSort):");
            grupa.Sort(CompareImie, Grupa.InsertSort);
            grupa.wypiszosoby();
            Console.WriteLine("\nSortowanie według nazwiska (BubbleSort):");
            grupa.Sort(CompareNazwisko, Grupa.BubbleSort);
            grupa.wypiszosoby();

            Console.WriteLine("Sortowanie według imienia (BubbleSort):");
            grupa.Sort(CompareImie, Grupa.BubbleSort);
            grupa.wypiszosoby();
            Console.WriteLine("\nSortowanie według nazwiska (InsertSort):");
            grupa.Sort(CompareNazwisko, Grupa.InsertSort);
            grupa.wypiszosoby();


        }
    }
}
