using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
internal class P1_11
    {
        Dictionary<string, int> wartosciKart = new Dictionary<string, int>(){
                {"as", 11}, {"dziesiatka", 10}, {"krol", 4}, {"dama", 3}, {"walet", 2}, {"dziewiatka", 0}
            };
        public void main(String[] args)
    {
            //Gracz podaje słowne wartości pięciu otrzymanych kart.
            //Program liczy sumaryczną wartość tych kart, przyjmując, że: as = 11 pkt., dziesiątka = 10 pkt., król = 4 pkt., dama = 3 pkt., walet = 2 pkt., dziewiątka = 0 pkt.
            // b) Wykonaj to samo zadanie losując dowolnie podaną liczbę kart.
            Console.WriteLine("Black jack game: podaj karty");
            string line = Console.ReadLine();
            Console.WriteLine(line);
            int suma = 0;
            for (var i = 0; i < line.Split().Length; i++)
            {
                string karta = line.Split()[i];
                int value = wartosciKart[karta];
                suma += value;
            }

            Console.WriteLine("Karty maja pkt:" + suma + " pkt.");
            Console.WriteLine("Kasjer : ");
            Console.WriteLine("Podaj liczbe kart");
            decimal liczbakart = decimal.Parse(Console.ReadLine());
            decimal sumakrupiera = 0;
            for (int i = 0; i < liczbakart; i++)
            {
                List<string> keys = new List<string>(wartosciKart.Keys);
                Random rand = new Random();
                string karta = keys[rand.Next(keys.Count)];
                Console.WriteLine(karta);
                sumakrupiera = sumakrupiera + obliczwartosckart(karta);
            }
            Console.WriteLine("Suma krupiera:" + sumakrupiera);
        }


        decimal obliczwartosckart(string line)
        {   
            //zmienna z suma kart
            int suma = 0;

            for (var i = 0; i < line.Split().Length; i++)
            {
                string karta = line.Split()[i];
                //odczyt wartosci z mapy/dictionary za pomoca string-a
                int value = wartosciKart[karta];
                //dodawanie wyniku
                suma += value;
            }
            return suma;
        }
    }
}