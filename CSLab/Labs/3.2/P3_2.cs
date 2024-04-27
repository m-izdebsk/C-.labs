using CSLab.Labs._2._6;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._2
{
    internal class P3_2
    {
        public void main(string[] args)
        {
            Produkt2 product2 = new Produkt2("test", 12f, "kg", DateTime.Now, 23.0f);
            //Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]
            Debug.Assert(product2["nazwa"] == "test");


        }
    }
}
