namespace CSLab.Spr2.Zad2_1
{
    internal class Kwadrat:Figura
    {
        public double bok { get; }

        public Kwadrat(double bok)
        {
            this.bok = bok;
        }

        public override double Pole()
        {
            return bok * bok;
        }

        public override double Obwod()
        {
            return 4 * bok;
        }
    }
}
