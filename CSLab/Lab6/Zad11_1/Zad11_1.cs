using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab6.Zad11_1
{
    internal class Zad11_1
    {
        public void main(string[] args) {
            Produkt produkt = new Produkt("test", 1.0d, 1.0d);
            Console.WriteLine("Podaj cene:");
            try
            {
                double cena = Double.Parse(Console.ReadLine());
                produkt.setVat(cena);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Cos poszlo nie tak");
            }

            Console.WriteLine(produkt.ToString());


        }
    }
}
