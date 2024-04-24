using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P1_1 {
        
        public void main(String[] args)
        {
            //Napisz w edytorze tekstowym program w C# wypisujący tekst podany jako parametr uruchomienia. Skompiluj z linii komend i uruchom.
            Console.WriteLine("Print args[] array");
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            else {
                Console.WriteLine("args are empty");
            }



        }

    
    
    }
    
}
