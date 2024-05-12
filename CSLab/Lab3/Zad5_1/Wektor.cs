
using System.Numerics;

namespace CSLab.Lab3.Zad5_1;


/*
Kod bazowy w projekcie Wektor
V.1
W klasie Wektor zdefiniuj operatory
    a. dodawania dwóch wektorów (na bazie metody add)
    b. mnożenia wektora przez liczbę (skalowanie)
    c. mnożenia dwóch wektorów (iloczyn skalarny)

*/
internal class Wektor
{
    public double[] Wspolrzedne;
    public int Wymiar;

    public Wektor(int wymiar, double[] wspolrzedne)
    {
        Wymiar = wymiar;
        Wspolrzedne = wspolrzedne;
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


    //    a. dodawania dwóch wektorów (na bazie metody add)
    public double sum(Wektor wektor) {
        return wektor.sum() + this.sum();
    }


    ////    b. mnożenia wektora przez liczbę (skalowanie)
    public Wektor scale(int scalar) {
        Wektor copy = this.copy();
        for(int i=0;i<this.Wspolrzedne.Length;i++)
        {
            copy.Wspolrzedne[i] = scalar * copy.Wspolrzedne[i];
        }
        return copy;
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

    ///mnożenia dwóch wektorów (iloczyn skalarny)
    public double dotProduct(Wektor wektor)
    {
        if (this.Wspolrzedne.Length != wektor.Wspolrzedne.Length)
        {
            throw new ArgumentException("Wektory musza miesc takie same rozmiary!!!");
        }
        
        double result = 0;
        for (int i = 0; i < wektor.Wspolrzedne.Length; i++)
        {
            result += wektor.Wspolrzedne[i] * this.Wspolrzedne[i];
        }

        return result;

    }
    public Wektor copy()
    {
        // Create a new instance of MyClass
        Wektor copiedObject = new Wektor(this.Wymiar,this.Wspolrzedne);

        // Return the new instance
        return copiedObject;
    }

}