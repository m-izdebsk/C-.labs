
//protected delegate decimal Działanie(decimal x, decimal y);


namespace CSLab.Zad2._2;


internal class Zad9_2
{
    decimal Dodaj(decimal x, decimal y) => x + y;
    decimal Odejmij(decimal x, decimal y) => x - y;
    decimal Pomnóż(decimal x, decimal y) => x * y;
    decimal Podziel(decimal x, decimal y) => y != 0 ? x / y : 0;

    public void main(string[] args)
    {
        Console.WriteLine("Podaj trzy liczby:");

        // Pobieranie trzech liczb z klawiatury
        decimal liczba1 = Convert.ToDecimal(Console.ReadLine());
        decimal liczba2 = Convert.ToDecimal(Console.ReadLine());
        decimal wynik = Convert.ToDecimal(Console.ReadLine());

        // Tablica z dostępnymi operacjami
        Działanie[] operacje = { Dodaj, Odejmij, Pomnóż, Podziel };

        // Przejście przez wszystkie operacje i znalezienie odpowiedniej
        Działanie najlepszeDziałanie = null;
        decimal najlepszyWynik = decimal.MaxValue;
        foreach (Działanie operacja in operacje)
        {
            decimal obliczonyWynik = operacja(liczba1, liczba2);
            decimal różnica = Math.Abs(obliczonyWynik - wynik);
            if (różnica < najlepszyWynik)
            {
                najlepszyWynik = różnica;
                najlepszeDziałanie = operacja;
            }
        }

        Console.WriteLine($"Pierwsze dziaanie spelnajace wymagania: {najlepszeDziałanie.Method.Name}({liczba1}, {liczba2}) = {najlepszeDziałanie(liczba1, liczba2)}");
    }

}
