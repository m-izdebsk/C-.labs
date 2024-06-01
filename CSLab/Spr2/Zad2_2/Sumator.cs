/*
Zadanie 2 (7p):
Zadanie 2a: Stwórz klasę Sumator z:
• polem Liczby będącym tablicą liczb
• metodą Suma zwracającą sumę liczb z pola Liczby
• metodę SumaPodziel3 zwracającą sumę liczb z tablicy, które są podzielne przez 3
Zadanie 2b: Dodaj metodę: int IleElement≤w () zwracającej liczbę elementów na w tablicy
Zadanie 2c: Dodaj metodę wypisującą wszystkie elementy tablicy
Zadanie 2d: Dodaj metodę przyjmującą dwa parametry: lowIndex oraz highIndex, która
wypisze elementy o indeksach >= lowIndex oraz <= highIndex. Metoda powinna zadziałać poprawnie, gdy lowIndex lub highIndex wykraczają poza zakres tablicy (pominąć te elementy).

 
*/
namespace CSLab.Spr2.Zad2_2
{
    internal class Sumator
    {
        int[] liczby;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }
        public int suma()
        {
            return liczby.Sum();
        }
        public int SumaPodziel3()
        {
            return liczby.Where(n => n % 3 == 0).Sum();

        }

        //2b
        public int IleElementow()
        {
            return liczby.Length;

        }
        //2c
        public void printAll()
        {
            Console.WriteLine(string.Join(", ", liczby));
        }
         public void printAll(int[] all)
        {
            Console.WriteLine(string.Join(", ", all));
        }

        //2d
        public int[] subArray(int startIndex, int endIndex)
        {
            if (endIndex > liczby.Length)
            {
                Console.WriteLine("Zly indeks koncowy");
                return [];
            }
            if (startIndex < 0 || endIndex < 0)
            {
                Console.WriteLine("Indeks nie moze byc mniejszy od zera!");
                return [];
            }
            if (startIndex > endIndex)
            {
                Console.WriteLine("Zla kolejnosc parametrow");
                return [];
            }

            int[] subArray = liczby.Skip(startIndex).Take(endIndex + 1).ToArray();
            return subArray;

        }
    }
}
