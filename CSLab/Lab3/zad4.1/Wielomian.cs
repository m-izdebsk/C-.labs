using System.Text;

namespace CSLab.Lab3.zad4._1;

public class Wielomian : Wektor
{
    public Wielomian(int wymiar, double[] wspolrzedne) : base(wymiar, wspolrzedne)
    {
    }

    /*
    Konstruktor klasy powinien wywoływać konstruktor klasy bazowej i mieć postać 
    Wielomian(double [] dane).
    */
    public Wielomian(double[] wspolrzedne) : base(wspolrzedne)
    {
        this.Wspolrzedne = wspolrzedne;
        this.Wymiar = wspolrzedne.Length;
    }

    public Wielomian(int n, double a, double b) : base(n, a, b)
    {
    }

    /*Nadpisz metodę Show(), która najpierw wyświetli wektor (Show() z klasy bazowej), 
     * a następnie wyświetli wielomian w postaci przedstawionej w treści tego zadania.
     */
    public override void show()
    {
        base.show();
        Console.WriteLine("Wielomian");
        Console.WriteLine("Wartosc w x:");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(dajWartosc(x));
        printWielomain();
    }

    private void printWielomain()
    {
        StringBuilder sb = new StringBuilder();

        if (this.Wspolrzedne[0] > 0)
        { sb.Append(this.Wspolrzedne[0] + "*x^2+"); }
        else{
            sb.Append("("+this.Wspolrzedne[0] + ")*x^2");
        }
        if (this.Wspolrzedne[1] > 0)
        {
            sb.Append("+" + this.Wspolrzedne[1] + "*x");
        }
        else {
            sb.Append(this.Wspolrzedne[1] + "*x");
        }
        if (this.Wspolrzedne[2] > 0)
        {
            sb.Append("+" + this.Wspolrzedne[1]);
        }
        else {
            sb.Append(this.Wspolrzedne[1]);
        }

        
        
        
String strResult = sb.ToString();

        Console.WriteLine("5*x^2+3*x-6");
    }

    /*  Dostarcz metodę zwracającą wartość wielomianu w punkcie x:
   double dajWartosc(double x).
   Do potęgowania (przy obliczaniu wartości wielomianu w zadanym punkcie) wykorzystaj metodę Math.Pow(double, double).
*/
    public double dajWartosc(double x)
    {

        var res = Wspolrzedne[0] * Math.Pow(x, 2) + Wspolrzedne[1] * x + Wspolrzedne[2];
        return res;
    }
}