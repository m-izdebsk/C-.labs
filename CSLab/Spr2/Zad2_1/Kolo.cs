
namespace CSLab.Spr2.Zad2_1
{
    internal class Kolo : Figura
    {
        public double Promien { get; }
        public Kolo(double promien)
        {
            Promien = promien;
        }

        public override double Pole()
        {
          
            return Math.PI * Promien * Promien;
          
        }

        public override double Obwod()
        {
            return 2 * Math.PI * Promien;
        }
    }
}
