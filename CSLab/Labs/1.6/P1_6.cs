using CSLab.Labs._1._6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P1_6
    {

        public void main(String[] args)
        {
            //wczytanie wagi
            Console.Write("Podaj wage w kg: ");
            //Wczytanie danych z linii polecen args[0] i args[1]
            decimal waga =decimal.Parse(Console.ReadLine());


            Console.WriteLine("Podaj wzrost w metrach");
            decimal wzrost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("obliczanie BMI:");
            BmiCalcService.printBmiStatus(BmiCalcService.calculateBmi(waga, wzrost));
        }
    }
}
