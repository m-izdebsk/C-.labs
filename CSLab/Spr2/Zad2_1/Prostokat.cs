using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Spr2.Zad2_1
{
    internal class Prostokat:Figura

    {

        public Prostokat(double a, double b) {
            this.bokA = a;
            this.bokB = b;
        }
        public double bokA { get; }
        public double bokB { get; }

        public override double Pole() {
            return bokA * bokB;
        }

        public override double Obwod()
        {
            return bokA * 2 + bokB * 2;
        }
    }
}
