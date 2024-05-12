using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Zbuduj strukturę Opakowanie pozwalającą przechowywać informację o wymiarach i materiale, 
 * z którego zrobiono opakowanie. 
 * Poza odpowiednimi polami struktura ta powinna mieć konstruktor, metodę ToString() 
 * oraz właściwość (do odczytu) obliczającą objętość opakowania.
 */
namespace CSLab.Lab4.Zad6_3
{
    internal class Opakowanie
    {
        public double Wysokosc, Szerokosc, Dlugosc;
        public Material material;
        public Opakowanie(double x,double y, double z, Material material) {
            this.Wysokosc = x;
            this.Szerokosc = y;
            this.Dlugosc = z;
            this.material = material;
        }
        public double obliczObjetosc() { 
            return this.Wysokosc * this.Szerokosc * this.Dlugosc;
        }
        public override string ToString()
        {
            return $"Opakowanie zrobiony z: {material},\nWymiary: {Wysokosc} x {Szerokosc} x {Dlugosc}, Objętość: {obliczObjetosc()}";
        }
    }
}
