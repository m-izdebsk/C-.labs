using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._1._6
{
    internal class BmiCalcService
    {
        public static decimal calculateBmi(decimal waga, decimal wzrost) {
            Console.WriteLine("obliczanie BMI");
            Console.WriteLine(waga);
            decimal bmi = waga / (wzrost * wzrost);
            Console.WriteLine("Twoj BMI wynosi: " + bmi.ToString("0.##"));
            return bmi;
        }

        public static void printBmiStatus(decimal bmi) {
            if (bmi > 40)
            {
                Console.WriteLine("Masz 3 stopien otylosci");
            }
            else if (bmi > 35)
            {
                Console.WriteLine("Masz 2 stopien otylosci");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("Masz 1 stopien otylosci");

            }
            else if (bmi > 25)
            {
                Console.WriteLine("Masz nadwage");
            }
            else if (bmi > 20)
            {
                Console.WriteLine("Jest ok");
            }
            else if (bmi > 15)
            {
                Console.WriteLine("Zjedz cos");
            }

        }
    }
}
