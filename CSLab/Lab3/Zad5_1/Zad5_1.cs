using System.Diagnostics;

namespace CSLab.Lab3.Zad5_1;

internal class Zad5_1
{
    internal void main(string[] args)
    {
        Wektor wektor = new Wektor(3, [1, 2, 3]);
        Wektor wektor2 = new Wektor(3, [1, 2, 3]);
        double sum = wektor.sum(wektor2);
        //test c: mnożenia dwóch wektorów (iloczyn skalarny)
        Console.WriteLine(wektor.dotProduct(wektor2));
        Debug.Assert(wektor.dotProduct(wektor2) == 14d);
        //test a: sumowanie wektorow
        Debug.Assert(sum==12d);
        //test b. mnożenia wektora przez liczbę (skalowanie)
        Debug.Assert(wektor.scale(2).sum()==12d);
        
       



    }
}