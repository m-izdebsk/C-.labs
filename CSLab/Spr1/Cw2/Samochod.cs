using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Spr1.Cw2
{
    public abstract class Samochod
    {
        string kolor{ get; set; }
        string marka{ get; set; }
        double pojemnoscSilnika { get; set; }

        //public abstract void WypiszKolor();
        virtual public  void WypiszKolor() { Console.WriteLine("Kolor abstrakcyjny: " + this.kolor); }
        virtual public  void WypiszMarke(){ Console.WriteLine("Marka abstrakcyjna: " + this.marka); }
    virtual public void WypiszPojemnoscSilnika() { Console.WriteLine("Pojemnosc abstrakcyjna: " + this.pojemnoscSilnika); }
    }

}
