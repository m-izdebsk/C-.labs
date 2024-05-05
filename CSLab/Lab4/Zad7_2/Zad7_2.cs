using System.Diagnostics;

namespace CSLab.Labs._3._4.Lab4.Zad7_2;

public class Zad7_2
{
    public void main(string[] args)
    {
        var stos = new Stos<string>();
        stos.dodaj("test1");
        stos.dodaj("test2");
        stos.dodaj("test3");

        Debug.Assert(stos.pierwszy() == "test3");
        Debug.Assert(stos.usun() == "test3");
        var stos2 = new Stos<int>();
        stos2.dodaj(1);
        stos2.dodaj(2);
        stos2.dodaj(3);
        Debug.Assert(stos2.usun() == 3);
        var fifo = new FIFO<string>();
        fifo.dodaj("test");
        fifo.dodaj("test2");
        fifo.dodaj("test3");
        Debug.Assert(fifo.pierwszy() == "test");
        Debug.Assert(fifo.usun() == "test");
        Debug.Assert(fifo.usun() == "test2");
        Debug.Assert(fifo.usun() == "test3");
    }
}