using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_8
{

    public void main(String[] args)
    {
            //Napisz program, który wyświetla 10 kolejnych liczb (np. od 0 do 9) przy użyciu pętli. 
            //            Napisz 3 wersje tego programu z użyciem pętli for, while oraz do while.
            int loopNumber = 10;
            int startFrom = 0;
            Console.WriteLine("Let's check loops:");
            {
                Console.WriteLine("for:");
                for (int i = startFrom; i < loopNumber; i++)
                {
                    Console.WriteLine(i);
                }
                int counter = startFrom;
                Console.WriteLine("while:");
                while (counter < loopNumber) {
                    Console.WriteLine(counter);
                    counter++;
                }
                counter = startFrom;
                Console.WriteLine(" do while:");
                do { 
                    Console.WriteLine(counter);
                    counter++;
                } while (counter < loopNumber);
                    


            }
            
        
        
    }
}
}
