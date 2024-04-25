using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_2
{

    public void main(String[] args)
    {
            //Napisz program przeliczający km/h na m/s. Program prosi o podanie wartości w km/h, dokonuje przeliczenia i wypisuje tę wartość w m/s.
            Console.WriteLine("Enter km/h");
            try { 
            decimal data= decimal.Parse(Console.ReadLine());
                decimal mps = (data*1000) / 3600;

                Console.WriteLine("m/s="+mps);
            }catch (FormatException)
            {
                Console.WriteLine("Wrong data!");
                this.main(args);
            }

        }
    }
}
