using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_9
{

    public void main(String[] args)
    {
            //Napisz program, który dodaje n kolejnych liczb naturalnych  przy użyciu pętli. 
            //Zliczanie ma trwać dotąd dopóki suma nie przekroczy określonej granicy. 
            //Wówczas program ma skończyć działanie bez doliczenia tego składnika, który spowodował przekroczenie ustalonego progu.
            //Program powinien podać, ile składników policzył i ile wynosi suma.
            //Napisz trzykrotnie ten program -przy użyciu pętli for, while, do while.

            int maxValue = 100;
            int currentValue = 0;
            int step = 0;
            for(int i = 0; i < maxValue; i+=step)
            {
                step++;
                currentValue = i;
            }
            Console.WriteLine("for:"+currentValue);
            currentValue = 0;
            step= 0;
            while(currentValue <= maxValue) { 
            currentValue = currentValue + step;
                step++;
            }
            Console.WriteLine("do:" + (currentValue-step+1));
            currentValue= 0;
            step = 0;
            do { currentValue += step;
                step++;
            }
            while(currentValue < maxValue);
            Console.WriteLine("do while:"+(currentValue-step+1));
        }
    }
}
