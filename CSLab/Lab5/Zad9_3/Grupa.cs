using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad9_3
{
    public delegate void WypiszDelegate();
    internal class Grupa
    {
        private WypiszDelegate _metodaWypisywania;

        public Grupa(WypiszDelegate metodaWypisywania)
        {
            _metodaWypisywania = metodaWypisywania;
        }
        public void zmienWypisywania(WypiszDelegate metodaWypisywania)
        {
            this._metodaWypisywania = metodaWypisywania;
        }
        public static void wypisz1()
        {
            Console.WriteLine("1") ;
        }
        public static void wypisz2() {
            Console.WriteLine(  "2");
        }
        public static void wypisz3() {
            Console.WriteLine("3");
        }
        public void Wypisz()
        {
            _metodaWypisywania();
        }


    }
}
