using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
II.5 (nowy projekt ‘wektor’)
(Klasy, metody, tablice)
Zbuduj klasę Wektor, która umożliwi wykonanie prostych operacji na wektorach liczb rzeczywistych.

a.Klasa powinna zawierać pola reprezentujące wymiar wektora (czyli liczbę współrzędnych) oraz tablicę jego współrzędnych
b.Konstruktor powinien alokować pamięć dla tablicy współrzędnych wektora oraz wypełniać ją wartościami z podanej jako parametr tablicy liczb.
Zatem konstruktor powinien mieć postać Wektor(int n, double[] dane).
c.Dostarcz metodę pokazywania obiektów void show().
d.Dostarcz metodę, która zsumuje wszystkie współrzędne wektora.
e.Dostarcz metodę zwracającą wektor, która doda do siebie wywołujący ją wektor i wektor podany jako argument Wektor add(Wektor).

     */
namespace CSLab
{
    class Wektor
    {
        public int Wymiar;
        public double[] Wspolrzedne;
        public Wektor(int wymiar, double[] wspolrzedne)
        {
            this.Wymiar = wymiar;
            this.Wspolrzedne = wspolrzedne;
        }
        //c.Dostarcz metodę pokazywania obiektów void show().
        public void show()
        {
            Console.WriteLine("Współrzędne wektora:");
            foreach (var item in Wspolrzedne)
            {
                Console.Write(item.ToString().PadRight(4));
            }
        }
        //d.Dostarcz metodę, która zsumuje wszystkie współrzędne wektora.
        public double sum()
        {
            double sum = 0;
            foreach (var item in this.Wspolrzedne)
            {
                sum += item;

            }
            return sum;
        }
        //e.Dostarcz metodę zwracającą wektor, która doda do siebie wywołujący ją wektor i wektor podany jako argument Wektor add(Wektor).
        public Wektor add(Wektor wektor)
        {
            if(this.Wspolrzedne==null || wektor.Wspolrzedne==null||wektor.Wspolrzedne.Length!=this.Wspolrzedne.Length)
            {
                throw new Exception("Wypary wektorow sa rozne lub jeden z wektoro jest pusty");
            }
            double sum = 0;
            double[] result = new double[wektor.Wspolrzedne.Length];
            for (int i = 0; i < this.Wspolrzedne.Length; i++) {
                result[i]=this.Wspolrzedne[i] + wektor.Wspolrzedne[i];
            }
            return new Wektor(Wymiar, result);
        }
    }
}
