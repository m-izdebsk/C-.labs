using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_5
    {
        /*
II.5 (nowy projekt ‘wektor’)
(Klasy, metody, tablice)
Zbuduj klasę Wektor, która umożliwi wykonanie prostych operacji na wektorach liczb rzeczywistych.

a.Klasa powinna zawierać pola reprezentujące wymiar wektora (czyli liczbę współrzędnych) oraz tablicę jego współrzędnych
b.Konstruktor powinien alokować pamięć dla tablicy współrzędnych wektora oraz wypełniać ją wartościami z podanej jako parametr tablicy liczb.
Zatem konstruktor powinien mieć postać Wektor(int n, double[] dane).
c.Dostarcz metodę pokazywania obiektów void show().
d.Dostarcz metodę, która zsumuje wszystkie współrzędne wektora.
e.Dostarcz metodę zwracającą wektor, która doda do siebie wywołujący ją wektor i wektor podany jako argument Wektor add(Wektor).

        */

        public void main(string[] args)
        {
            Wektor wektor = new Wektor(1, [1, 1, 1]);
            Wektor wektor2 = new Wektor(1, [1, 1, 1]);
            Wektor wektor3 = new Wektor(1, [2, 2, 2]);
            Wektor wektor4= new Wektor(2, [1, 2, 3.3]);
            

            //test sum
            double suma = wektor.sum();
            Debug.Assert(suma == 3);
            //test adding vectors
            Wektor wektorOut = wektor.add(wektor2);
            Debug.Assert(wektorOut.ToString()==wektor3.ToString());
            //test show
            wektor.show();
            
        }
    }
}
