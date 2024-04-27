using System;
using System.Collections;
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
namespace CSLab.Labs
{
    class Wektor
    {
        private static Random RANDOM_GENERATOR=new Random(); // pole klasy do generowania liczb losowych

        public int Wymiar;
        public double[] Wspolrzedne;
        public string quoteType = "[ ]";
        public Wektor(int wymiar, double[] wspolrzedne)
        {
            this.Wymiar = wymiar;
            this.Wspolrzedne = wspolrzedne;
        }
        //Zdefiniuj drugi konstruktor dla klasy Wektor postaci Wektor(double [] dane),
        //który przy tworzeniu obiektu klasy Wektor wymaga tylko podania tablicy współrzędnych.
        //Wskazówka: Wykorzystaj właściwość tablic o nazwie Length.
        public Wektor(double[] wspolrzedne)
        {
            this.Wymiar = wspolrzedne.Length;
            this.Wspolrzedne = wspolrzedne;
        }
        //Zdefiniuj(lub uzupełnij jak już istnieje) konstruktor statyczny, który będzie prosił o podanie z konsoli typu nawiasów służących do wypisywania wektorów na konsoli.Wybrany znak powinien pamiętany jako  pole klasy. 
        public static void setQuoteType() {
            Console.WriteLine("Current quote type:"+this.quoteType);
            Console.WriteLine("Enter new quote types");
            this.quoteType = Console.ReadLine();
        }

        //W klasie Wektor zdefiniuj statyczną metodę zbudujWektor(),
        //która tworzy nowy wektor na podstawie danych wprowadzonych z klawiatury i zwraca go jako wynik.
        //Wykorzystaj klasę statyczną Czytacz z projektu ‘klasy 1_4’. W razie potrzeby uzupełnij kod klasy Czytacz.
        public static Wektor zbudujWektor() {

            ArrayList myAL = new ArrayList();
            while (true) {
                Console.WriteLine("Enter new wektor value, press q if you want to leavey...");
                string outputValuey = Console.ReadLine();
                if (outputValuey.ToLower() == "q") {
                    break;
                }
                myAL.Add(decimal.Parse(outputValuey));
            }
            //naiwne przepisanie elementow ArrayList to list
            double[] output = new double[myAL.Count];
            for(int i = 0; i < myAL.Count; i++)
            {
                output[i] = double.Parse(myAL[i].ToString());
            }
            return new Wektor(output);
        }

        public Wektor(int n, double a, double b) {
            this.Wymiar = n;
            this.Wspolrzedne = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                this.Wspolrzedne[i] = a + (b - a) * RANDOM_GENERATOR.NextDouble();
            }
        }
        //c.Dostarcz metodę pokazywania obiektów void show().
        public void show()
        {
            Console.WriteLine("Współrzędne wektora:");
            foreach (var item in Wspolrzedne)
            {
                Console.Write(Math.Round(item, 2).ToString().PadRight(6));
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
        public override string ToString()
        {
            String elements = "[";
            foreach (var item in Wspolrzedne)
            {
                elements += item+",";
            }
            elements = elements.Remove(elements.Length-1);
            elements += "]";
            return "Wektor: Wymiar:" + Wymiar + " elements:" + elements;
        }
    }
}
