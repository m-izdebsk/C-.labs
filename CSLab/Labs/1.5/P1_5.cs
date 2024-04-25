using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_5
{

    public void main(String[] args)
    {
            //Napisz program, który wczytuje liczbę od 1 do 7 i wyświetla nazwę dnia tygodnia (1 to poniedziałek). Zastosuj instrukcję switch.
            Console.WriteLine("Podaj nr");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Pn");
                    break;
                case 2:
                    Console.WriteLine("wt");
                    break;
                case 3:
                    Console.WriteLine("sr");
                    break;
                case 4:
                    Console.WriteLine("czw");
                    break;
                case 5:
                    Console.WriteLine("pt"); break;
                case 6:
                    Console.WriteLine("so");break;
                case 7:
                    Console.WriteLine("nd");
                    break;
            }
        }
    }
}
