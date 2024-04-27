using CSLab.Labs._2._11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLab
{
    internal class P2_11
/*Utwórz klasę RandomUtility zawierającą narzędzia do generowania losowego.
W klasie zdefiniuj metody: 
a. do losowego generowania liczby z podanego przedziału dla różnych typów liczbowych(int, decimal, double): randomInt(a, b), randomDecimal(a, b), randomDouble(a, b)
b. do losowego generowania łańcucha znakowego(stringa) składającego się z n dowolnych znaków: randomString(n)
dla uproszczenia można założyć, że string ma składać się wyłącznie z liter
c. do losowego wybierania n elementów z podanej tablicy (z możliwością powtórzeń lub bez): randomFromArray(n, array, rep)
Przetestuj te metody w klasie testowej(z metodą Main()).
*/
    {
        public void main(string[] args)
        {
            Console.WriteLine("Random double:");
            Console.WriteLine(RandomUtility.randomDouble(1.0, 3.0));
            Console.WriteLine("Random string:");
            Console.WriteLine(RandomUtility.randomString(11));
            Console.WriteLine("Random int:");
            Console.WriteLine(RandomUtility.randomInt(1,100));


           
        }
    }
}
