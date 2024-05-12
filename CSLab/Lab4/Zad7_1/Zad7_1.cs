
using System.Diagnostics;

namespace CSLab.Lab4.Zad7_1;

public class Zad7_1
{
    public void main(string[] args)
    {
        Wektor wektor = new Wektor(3, [1, 2, 3]);
        Debug.Assert(wektor.sum() == 6);
        Debug.Assert(wektor.srednia() == 2);
        Debug.Assert(wektor.max() == 3);
    }
}