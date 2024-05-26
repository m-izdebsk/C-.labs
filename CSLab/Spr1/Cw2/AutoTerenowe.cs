using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Spr1.Cw2
{
    internal class AutoTerenowe : Samochod
    {
        private string kolor;
        private string marka;
        private double pojemnoscSilnika;
        public AutoTerenowe(string kolor, string marka, double pojemnoscSilnika)
        {
            this.kolor = kolor;
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }
        public override void WypiszKolor()
        {
            Console.WriteLine("Kolor" + this.kolor);
        }

        public override void WypiszMarke()
        {
            Console.WriteLine("Marka" + this.marka);
        }

        public override void WypiszPojemnoscSilnika()
        {
            Console.WriteLine("Poj:" + this.pojemnoscSilnika);
        }
    }
}
