using CSLab.Labs._2._7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_7
    {
        //Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().

        public void main(string[] args)
        {
            
            var s1 = new Sprzedaz("Auto", 2, new(13123.25));
            var s2 = new Sprzedaz("Cukier", 2, new(10.25));
            var s3 = new Sprzedaz("Ryba", 2, new(2.25));
            var z = new Zamowienie(DateTime.Now, "Google");
            z.DodajPozycje(s1);
            z.DodajPozycje(s2);
            z.DodajPozycje(s3);
            s1.printData();
            z.info();
        }
    }
}
