namespace CSLab.Lab3.zad4._1;

public class Wielomian : Wektor
{
    public Wielomian(int wymiar, double[] wspolrzedne) : base(wymiar, wspolrzedne)
    {
    }

    public Wielomian(double[] wspolrzedne) : base(wspolrzedne)
    {
        Wspolrzedne = wspolrzedne;
    }

    public Wielomian(int n, double a, double b) : base(n, a, b)
    {
    }


    public override void show()
    {
        base.show();
        Console.WriteLine("Wielomian");
        Console.WriteLine("Wartosc w x:");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(dajWartosc(x));
    }

    public double dajWartosc(double x)
    {
        var res = Wspolrzedne[0] * Math.Pow(x, 2) + Wspolrzedne[1] * x + Wspolrzedne[2];
        return res;
    }
}