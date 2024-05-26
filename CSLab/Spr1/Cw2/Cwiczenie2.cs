using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Spr1.Cw2
{
    internal class Cwiczenie2
    {
        public void main(string[] args)
        {
            Console.WriteLine("Sprawdzian 1 cw 2");
            List<Samochod> list = new List<Samochod>();
            list.Add(new Kabriolet("Czerwony", "Lamborgini", 2.0d));
            list.Add(new Kabriolet("Czarny", "Pontiac", 2.0d));
            list.Add(new AutoTerenowe("Czarny", "Outlander", 4.0d));
            Samochod anycar = new AutoTerenowe("Czerwony", "Mercedes", 4.0d);
            Samochod samochód = (Samochod)anycar;
            list.Add(samochód);

            foreach (Samochod car in list)
            {
                car.WypiszMarke();
                car.WypiszKolor();
                car.WypiszPojemnoscSilnika();
            } 
           


        }

    }
}
