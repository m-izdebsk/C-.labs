/*Utwórz klasę RandomUtility zawierającą narzędzia do generowania losowego.
W klasie zdefiniuj metody:
a. do losowego generowania liczby z podanego przedziału dla różnych typów liczbowych(int, decimal, double): randomInt(a, b), randomDecimal(a, b), randomDouble(a, b)
b. do losowego generowania łańcucha znakowego(stringa) składającego się z n dowolnych znaków: randomString(n)
dla uproszczenia można założyć, że string ma składać się wyłącznie z liter
c. do losowego wybierania n elementów z podanej tablicy (z możliwością powtórzeń lub bez): randomFromArray(n, array, rep)
Przetestuj te metody w klasie testowej(z metodą Main()).
*/

namespace CSLab.Labs._2._11;

internal class RandomUtility
{
    private static readonly Random random = new();

    public static int randomInt(int start, int end)
    {
        return random.Next(start, end);
    }

    public static decimal randomDecimal(decimal start, decimal end)
    {
        return start + (decimal)(random.NextDouble() * (double)(end - start));
    }

    public static double randomDouble(double start, double end)
    {
        return start + random.NextDouble() * (end - start);
    }

    public static string randomString(int length)
    {
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

    public static object[] randomFromArray(int n, object[] array, bool repeat)
    {
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