using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad9_3
{
    internal class Zad9_3
    {
        public void main(string[] args) {

            Grupa grupa = new Grupa(Grupa.wypisz3);
            grupa.Wypisz();
            grupa.zmienWypisywania(Grupa.wypisz2);
            grupa.Wypisz();
            grupa.zmienWypisywania(Grupa.wypisz1);
            grupa.Wypisz();
        }
        

    }
}
