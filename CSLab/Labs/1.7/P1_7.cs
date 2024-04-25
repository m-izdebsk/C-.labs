using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_7
{

    public void main(String[] args)
    {
            if (args.Length == 0) {
                throw new ArgumentException("Missing args");
            }
            //wczytanie wagi
            Console.Write("Podaj wage w kg: ");
            //Wczytanie danych z linii polecen args[0] i args[1]
            decimal waga = Decimal.Parse(args[0]);

            Console.WriteLine("Podaj wzrost w metrach");
            decimal wzrost = decimal.Parse(args[1]);

            Console.WriteLine("obliczanie BMI");
            Console.WriteLine(waga);
            decimal bmi = waga / (wzrost * wzrost);
            Console.WriteLine("Twoj BMI wynosi: " + bmi.ToString("0.##"));
          
        }
}
}
