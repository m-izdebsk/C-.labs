using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P1_10
    {

        public void main(String[] args)
        {
            //
            Console.WriteLine("Enter a number 1-99(slownie)");
            string numbersl = Console.ReadLine();
            string[] number = numbersl.Split();

            string[] unitsMap = { "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć", "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
            string[] tensMap = { "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
            int result = 0;
            if (number.Length >0)
            {
               
            
                    int index = 1;
                    foreach (string unit in tensMap) {
                        bool areDifferent = !unit.Equals(tensMap[index], StringComparison.OrdinalIgnoreCase);

                        if (areDifferent) {
                            result += (index * 10);

                            break;
                        }else { 
                            index++;
                        }
                    }

             
            }
            Console.WriteLine("Rezultat:" + result); ;
        }
    }
}
