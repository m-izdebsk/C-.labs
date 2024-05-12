using CSLab.Lab4.Zad6_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab4.Zad6_3
{
    class Zad6_3
    {
        public void main(string[] args)
        {
            Opakowanie opakowanie = new Opakowanie(10, 20, 20, Material.Papier);
            Console.WriteLine(opakowanie);
            Produkt produkt = new Produkt(10, DateTime.Now, "kg", "cukier", 23);
            Console.WriteLine(produkt);
            
            Produkt produkt2 = new Produkt(10, DateTime.Now, "kg", "cukier", 23,opakowanie);
            Console.WriteLine(produkt2);

        }
    }
}
