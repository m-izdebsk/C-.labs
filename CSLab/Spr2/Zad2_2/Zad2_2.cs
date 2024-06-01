using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Zadanie 2 (7p):
Zadanie 2a: Stwórz klasę Sumator z:
• polem Liczby będącym tablicą liczb
• metodą Suma zwracającą sumę liczb z pola Liczby
• metodę SumaPodziel3 zwracającą sumę liczb z tablicy, które są podzielne przez 3
Zadanie 2b: Dodaj metodę: int IleElement≤w () zwracającej liczbę elementów na w tablicy
Zadanie 2c: Dodaj metodę wypisującą wszystkie elementy tablicy
Zadanie 2d: Dodaj metodę przyjmującą dwa parametry: lowIndex oraz highIndex, która
wypisze elementy o indeksach >= lowIndex oraz <= highIndex. Metoda powinna zadziałać poprawnie, gdy lowIndex lub highIndex wykraczają poza zakres tablicy (pominąć te elementy).

 */
namespace CSLab.Spr2.Zad2_2
{
    internal class Zad2_2
    {
        public void main(string[] args)
        {
            Sumator sumator = new Sumator([1, 2, 3, 4, 5, 6]);
            Console.WriteLine(sumator.suma());
            Console.WriteLine(sumator.SumaPodziel3());
            Debug.Assert(sumator.suma() == 21);
            Debug.Assert(sumator.SumaPodziel3() == 9);
            //2b
            Debug.Assert(sumator.IleElementow() == 6);
            //2c
            sumator.printAll();

            //2d
            sumator.printAll(sumator.subArray(0, 5));
            sumator.printAll(sumator.subArray(-3, 5));
            sumator.printAll(sumator.subArray(3, -5));
            sumator.printAll(sumator.subArray(5, 1));
        }
    }
}
