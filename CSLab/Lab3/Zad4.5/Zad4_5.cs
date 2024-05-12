using System.Diagnostics;

namespace CSLab.Lab3.Zad4._5;

public class Zad4_5
{

    /*
    IV.5 Kod bazowy w projekcie klasy 2_3
    Do klasy Osoba dodaj pole numer przechowujące unikalny dla osoby numer (może być id itp.). W metodzie wypisującej dodaj wyświetlanie numeru osoby. Następnie uzupełnij pozostały kod tak, aby numery przydzielane były także pracownikom i studentom. Każda numeracja powinna być odrębna. Skorzystaj z mechanizmu przesłaniania.
    Wsk.: Pomocniczo należy użyć pola statycznego w klasie Osoba
    */
    public void main(string[] args)
    {
        Student student1 = new Student("imie","nazwisko");
        Student student2 = new Student("imie","nazwisko");
        Student student3 = new Student("imie","nazwisko");
        Pracownik worker = new Pracownik("imie","nazwisko");
        Pracownik worker2 = new Pracownik("imie","nazwisko");
        Pracownik worker3 = new Pracownik("imie","nazwisko");
        Console.WriteLine(worker3);
        Debug.Assert(worker3.getId() == 7);


    }
}