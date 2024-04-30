using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Narzedzia.Zad1
{
    class RandomUtility
    {
        //static random
        private static readonly Random random = new Random();
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
            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = charSet[random.Next(charSet.Length)];
            }
            return new string(result);
        }

        static object[] RemoveElementFromArray(object[] array, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                List<object> tempList = new List<object>(array);
                tempList.RemoveAt(index);
                return tempList.ToArray();
            }
            else
            {
                Console.WriteLine("Invalid index. Index is out of range.");
                return array;
            }
        }


        //do losowego wybierania n elementów z podanej tablicy (z możliwością powtórzeń lub bez): randomFromArray(n, array, rep)
        public static object[] randomFromArray(int n, object[] array, bool repeat)
        {
            //sprawdzamy czy w przypadku bez powtorzen, mamy wystarczajaca liczbe dancyh na output.
            if (!repeat && array.Length < n)
            {
                throw new Exception("taki przypadek nie jest mozliwy");
            }

            object[] objects = new object[n];

            for (int i = 0; i < n; i++)
            {
                int randInt = randomInt(0, array.Length);
                objects[i] = array[randInt];
                if (!repeat)
                {
                    array = RemoveElementFromArray(array, randInt);

                }
            }
            return objects;

        }

    }
}
