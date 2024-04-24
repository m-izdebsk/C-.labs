using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_1

    {
        public void main(string[] args) {
            //Napisz program, który pobiera z wejścia liczbę x,
            //następnie serię x liczb wpisując je do tablicy,
            //w końcu wylicza sumę i średnią tych liczb wypisując wyliczone wartości na wyjście.
            Console.WriteLine("Enter array size:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("odczytano: " +number);
            int[] ints= new int[number];
            for (int i = 0; i < number; i++) {
                Console.WriteLine("Podaj liczbe "+(i+1)+":");
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma: "+ints.Sum());
            Console.WriteLine("Avg: "+(ints.Sum()/ints.Length));



        }
    }
}
