using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab3.Zad4._3;

/*
 Utwórz klasę Przelew dziedziczącą po klasie Transakcja.
Klasa, poza polami dostępnymi z klasy bazowej, powinna posiadać pole reprezentujące konto,
na które (z którego) został wykonany przelew. 
Zdefiniuj konstruktor przekazujący (poprzez parametry) wartości do pól obiektu (zarówno dziedziczonych jak i własnych). 
Skorzystaj z konstruktora klasy bazowej.
*/
internal class Przelew : Transakcja
{
    string nrKonta;
    public Przelew(DateTime dataRealizacji, string tytul, decimal kwota, string nrKonta) : base(dataRealizacji, tytul, kwota)
    {
        this.nrKonta = nrKonta;
    }
    /*Napisz metodę nadpisującą (niewirtualnie) metodę klasy bazowej do
     wypisywania informacji o transakcji na konsoli. Uzupełnij informację o konto docelowe (źródłowe).
     */
    public override string ToString()
    {
        return base.ToString()+"\nNumber konta:"+this.nrKonta;
    }

    internal string getNrKonta()
    {
        return this.nrKonta;
    }
    internal void setNrKonta(string nr)
    {
        this.nrKonta = nr;
    }
}
