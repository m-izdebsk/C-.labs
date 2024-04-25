using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_4
{

    public void main(String[] args)
    {
        //Napisz program, który sprawdza, czy podana liczba naturalna jest parzysta. 
        Console.WriteLine("Program 1.4:\nEnter a number:");

        string intput = Console.ReadLine();
        Console.WriteLine("Entered: "+intput + " number");
            //ternary operator
        string GetWeatherDisplay(string number) => int.Parse(number) % 2==0 ? "Parzysta" : "Nieparzysta";
        Console.WriteLine("Wprowadzona liczba jest:"+GetWeatherDisplay(intput));
        }
    }
}
