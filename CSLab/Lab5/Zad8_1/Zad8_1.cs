using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad8_1
{
    internal class Zad8_1
    {
        public void main(string[] args)
        {
            Wektor wektor = new Wektor(1, [1]);
            double sum = (double)wektor; // Konwersja jawna z Wektor na double
            Console.WriteLine("Konwersja jawna:"+sum);
            Wektor wektor2 = 5.0; // Konwersja niejawna z double na Wektor
            Console.WriteLine("Konwersja niejawna:"+wektor2);
        }

    }
}
