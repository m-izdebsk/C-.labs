namespace CSLab;

internal class P2_1

{
    public void main(string[] args)
    {
        //Napisz program, który pobiera z wejścia liczbę x,
        //następnie serię x liczb wpisując je do tablicy,
        //w końcu wylicza sumę i średnią tych liczb wypisując wyliczone wartości na wyjście.
        Console.WriteLine("Enter array size:");
        var number = int.Parse(Console.ReadLine());
        Console.WriteLine("odczytano: " + number);
        var ints = new int[number];
        for (var i = 0; i < number; i++)
        {
            Console.WriteLine("Podaj liczbe " + (i + 1) + ":");
            ints[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Suma: " + ints.Sum());
        Console.WriteLine("Avg: " + ints.Sum() / ints.Length);
    }
}