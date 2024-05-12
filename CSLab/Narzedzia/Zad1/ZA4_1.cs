namespace CSLab.Narzedzia.Zad1;

internal class ZA4_1
{
    internal void main(string[] args)
    {
        //metoda testowa
        var randomint = RandomUtility.randomInt(1, 10);
        var randomdouble = RandomUtility.randomDouble(1, 10);
        var randomDecimal = RandomUtility.randomDecimal(1, 10);

        Console.WriteLine(randomDecimal);
        Console.WriteLine(randomdouble);
        var randomstring = RandomUtility.randomString(10);

        Console.WriteLine(randomstring);
        Console.WriteLine(randomint);
    }
}