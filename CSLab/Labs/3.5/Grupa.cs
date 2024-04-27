using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._5
{
    class Grupa
    {
        public string Nazwa;
        public Grupa(string nazwa) { 
            this.Nazwa= nazwa;
        }
//tak wygladalby indeksator.
        public string this[int indeksCzlonka, string nazwaCechy]
        {
            get
            {
                return "niestety polecenie nie jest precyzyjne";

            }
        }
    }
}
