namespace CSLab.Narzedzia.Zad1;

internal class RandomUtility
{
    //static random
    private static readonly Random random = new();

    //metoda losujaca int z zakresu
    public static int randomInt(int start, int end)
    {
        return random.Next(start, end);
    }

    //metoda losujaca decimal z zakresu
    public static decimal randomDecimal(decimal start, decimal end)
    {
        return start + (decimal)(random.NextDouble() * (double)(end - start));
    }

    //metoda losujaca double z zakresu
    public static double randomDouble(double start, double end)
    {
        return start + random.NextDouble() * (end - start);
    }

    //metoda losujaca do generowania lancucha znakowego
    public static string randomString(int length)
    {
        //tablica znakow
        var charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var result = new char[length];
        for (var i = 0; i < length; i++) result[i] = charSet[random.Next(charSet.Length)];
        return new string(result);
    }

    private static object[] RemoveElementFromArray(object[] array, int index)
    {
        if (index >= 0 && index < array.Length)
        {
            var tempList = new List<object>(array);
            tempList.RemoveAt(index);
            return tempList.ToArray();
        }

        Console.WriteLine("Invalid index. Index is out of range.");
        return array;
    }


    //do losowego wybierania n elementów z podanej tablicy (z możliwością powtórzeń lub bez): randomFromArray(n, array, rep)
    public static object[] randomFromArray(int n, object[] array, bool repeat)
    {
        //sprawdzamy czy w przypadku bez powtorzen, mamy wystarczajaca liczbe dancyh na output.
        if (!repeat && array.Length < n) throw new Exception("taki przypadek nie jest mozliwy");

        var objects = new object[n];

        for (var i = 0; i < n; i++)
        {
            var randInt = randomInt(0, array.Length);
            objects[i] = array[randInt];
            if (!repeat) array = RemoveElementFromArray(array, randInt);
        }

        return objects;
    }
}