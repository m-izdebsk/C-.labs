using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Zadanie 1 (3p): Zdefiniuj abstrakcyjną klasę Figura, która określi wymagania dla klas po niej dziedziczących. 
Wymagania te mają umożliwić obliczenie pola figury (dostęp do pola figury ma być wykonany za pośrednictwem właściwości),
oraz jego obwodu (metoda). Stwórz klasy
dziedziczące po Figura: Koło, Prostokąt, Kwadrat oraz Trapez. 
Pamiętaj o utworzeniu odpowiednio sparametryzowanych konstruktorów pobierających jako 
parametr niezbędne dane wykonania obliczeń (np. długość boku itd.).
*/
namespace CSLab.Spr2.Zad2_1
{
    internal class Zad2_1
    {
        public void main(string[] args) {
            Kolo kolo = new Kolo(1);
            Console.WriteLine(kolo.Pole());
            Console.WriteLine(kolo.Obwod());

            Kwadrat kwadrat = new Kwadrat(1);
            Console.WriteLine(kwadrat.Pole());
            Console.WriteLine(kwadrat.Obwod());
            Prostokat prostokat = new Prostokat(1, 2);
            Console.WriteLine(prostokat.Pole());
            Console.WriteLine(prostokat.Obwod());

            Trapez trapez = new Trapez(1, 3, 4);
            Console.WriteLine(trapez.Pole());
            Console.WriteLine(trapez.Obwod());


        }
    }
}
