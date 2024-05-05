namespace CSLab.Lab3.zad4._1;

public class Wielomian : Wektor
{
    public Wielomian(int wymiar, double[] wspolrzedne) : base(wymiar, wspolrzedne)
    {
    }

    public Wielomian(double[] wspolrzedne) : base(wspolrzedne)
    {
        base.Wspolrzedne = wspolrzedne;
    }

    public Wielomian(int n, double a, double b) : base(n, a, b)
    {
    }



    public override void show()
    {
        base.show();
        Console.WriteLine("Wielomian");
        Console.WriteLine("Wartosc w x:");
        double x  = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(this.dajWartosc(x));
    }

    public double dajWartosc(double x)
    {
        double res = this.Wspolrzedne[0] * Math.Pow(x, 2) + this.Wspolrzedne[1]*x + this.Wspolrzedne[2];
        return res;
    }
}