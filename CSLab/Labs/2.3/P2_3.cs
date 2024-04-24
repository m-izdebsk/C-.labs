using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisz program wczytujący dwie liczby całkowite
//a następnie wyświetlający tabliczkę mnożenia
//w zakresie wyznaczonym przez te liczby.
//Przed wyświetleniem odpowiednie iloczyny należy zapisać w dwuwymiarowej tablicy.

namespace CSLab
{
    internal class P2_3
    {
        public void main(string[] args) {
            int padding = 4;
            //Napisz program wczytujący dwie liczby całkowite
            Console.WriteLine("Wczytaj liczbe 1");
            int l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wczytaj liczbe 2");
            int l2 = int.Parse(Console.ReadLine());
            int[,] tm = new int[l1+1,l2+1];
            for (int i = 0; i < tm.GetLength(0); i++) {
                for (int j = 0; j < tm.GetLength(1); j++) {
                    tm[i, j] = i * j;
                }
            }

            Console.Write("   ");
            for (int i = 0; i < tm.GetLength(1); i++)
            {
                Console.Write(i.ToString().PadRight(padding));
            }
            Console.WriteLine();
            for (int i = 0; i < tm.GetLength(0); i++) {
            Console.Write(i+": ");
            for (int j = 0; j < tm.GetLength(1); j++) {
                Console.Write(tm[i, j].ToString().PadRight(padding));
            }
            Console.WriteLine();
            }


        }
    }
}
