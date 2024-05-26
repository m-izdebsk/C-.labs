using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLab.Lab5.Zad8_3
{
    internal class Zad8_3
    {

        public void main(string[] args)
        {
            MojaData data = new MojaData(DateTime.Now.AddDays(-200));
            int niejawna = data;
            Console.WriteLine("Konwersja niejawna:" + niejawna);
            float jawna = (float)data;
            Console.WriteLine("Konwersja jawna:" + jawna);
        }


    }
}
