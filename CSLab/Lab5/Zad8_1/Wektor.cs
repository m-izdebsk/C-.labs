
namespace CSLab.Lab5.Zad8_1;

internal class Wektor
{
    public double[] Wspolrzedne;
    public int Wymiar;

    public Wektor(int wymiar, double[] wspolrzedne)
    {
        Wymiar = wymiar;
        Wspolrzedne = wspolrzedne;
    }
    // Operator konwersji jawnej z Wektora na double
    public static explicit operator double(Wektor w)
    {
        return w.sum();
    }

    // Operator konwersji niejawnej z double na Wektor
    public static implicit operator Wektor(double value)
    {
        return new Wektor(1, [value]);
    }
    //c.Dostarcz metodę pokazywania obiektów void show().
    public void show()
    {
        Console.WriteLine("Współrzędne wektora:");
        foreach (var item in Wspolrzedne) Console.Write(item.ToString().PadRight(4));
    }

    //d.Dostarcz metodę, która zsumuje wszystkie współrzędne wektora.
    public double sum()
    {
        double sum = 0;
        foreach (var item in Wspolrzedne) sum += item;
        return sum;
    }

    //e.Dostarcz metodę zwracającą wektor, która doda do siebie wywołujący ją wektor i wektor podany jako argument Wektor add(Wektor).
    public Wektor add(Wektor wektor)
    {
        if (Wspolrzedne == null || wektor.Wspolrzedne == null || wektor.Wspolrzedne.Length != Wspolrzedne.Length)
            throw new Exception("Wypary wektorow sa rozne lub jeden z wektoro jest pusty");
        double sum = 0;
        var result = new double[wektor.Wspolrzedne.Length];
        for (var i = 0; i < Wspolrzedne.Length; i++) result[i] = Wspolrzedne[i] + wektor.Wspolrzedne[i];
        return new Wektor(Wymiar, result);
    }

    public override string ToString()
    {
        var elements = "[";
        foreach (var item in Wspolrzedne) elements += item + ",";
        elements = elements.Remove(elements.Length - 1);
        elements += "]";
        return "Wektor: Wymiar:" + Wymiar + " elements:" + elements;
    }
}