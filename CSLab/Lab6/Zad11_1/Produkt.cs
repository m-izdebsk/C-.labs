using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab6.Zad11_1
{
    internal class Produkt
    {
        string nazwa;
        double cena;
        double vat;
        public Produkt(string nazwa, double cena, double vat)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.vat = vat;
        }
        public void setVat(double vat) {
            this.vat = vat;
        }
        public override string ToString()
        {
            return "Nazwa:" + this.nazwa + "\n" + "vat:" + this.vat;
        }
    }
}
