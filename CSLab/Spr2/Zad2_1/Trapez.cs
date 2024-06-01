

namespace CSLab.Spr2.Zad2_1
{
    internal class Trapez : Figura
    {
        public double podstawaA, podstawaB, wysokosc;
        public Trapez(double a, double b, double h) {
            this.podstawaA = a;
            this.podstawaB = b;
            this.wysokosc = h;
        }
        public override double Obwod()
        {
            double bok1 = Math.Sqrt(Math.Pow((podstawaB - podstawaA) / 2, 2) + Math.Pow(wysokosc, 2));
            double bok2 = bok1; 

            return podstawaA + podstawaB + bok1 + bok2;
        }

        public override double Pole()
        {
            return 1 / 2 * (podstawaA + podstawaB) * wysokosc;
        }
    }
}
