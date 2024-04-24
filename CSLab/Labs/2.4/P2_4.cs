using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_4
    {
        public decimal randUniqueNumber(int start, int end, ArrayList values)
        {
            Random random = new Random();
            int randomNumber = random.Next(start, end);
            if(values.Contains(randomNumber))
            {
                return randUniqueNumber(start, end, values);
            }
            else { 
                return randomNumber;
            }
        }
        public void main(string[] args)
        {
            //Wylosuj 5 liczb całkowitych w zakresie od 0 do 1000.
            //Następnie zbuduj tablicę, której wiersze będą tablicami
            //przechowującymi kolejne cyfry każdej z liczb.
            //
            //Użyj możliwie najmniej elementów tablicy.
            ArrayList randoms = new ArrayList { };
            object[] list = new object[5];
            for (int i = 0; i < 5; i++) {
                decimal random = randUniqueNumber(1, 5000, randoms);
                decimal[] newdecimal = new decimal[random.ToString().Length];
                for (int k = 0; k < random.ToString().Length; k++) {
                    char vkey = random.ToString()[k];
                    newdecimal[k] = decimal.Parse(vkey.ToString());
                }
                list[i]=newdecimal;
            }

            foreach (var item in list)
            {

                foreach(var value in (decimal[])item)
                {
                    Console.Write(value);
                }
                Console.WriteLine();
            }
        }
    }
}
