using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.NewFolder
{
    internal class Z4_1
    {

        internal void main(string[] args)
        {

            //metoda testowa
            int randomint = RandomUtility.randomInt(1, 10);
            double randomdouble = RandomUtility.randomDouble(1, 10);
            decimal randomDecimal = RandomUtility.randomDecimal(1, 10);

            Console.WriteLine(randomDecimal);
            Console.WriteLine(randomdouble);
            string randomstring = RandomUtility.randomString(10);
          
            Console.WriteLine(randomstring);
            Console.WriteLine(randomint);

        }
    }
}
