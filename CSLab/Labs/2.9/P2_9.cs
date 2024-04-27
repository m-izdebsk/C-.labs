using CSLab.Labs._2._9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_9
    {
        public void main(string[] args)
        {
            Grupa[] group = new Grupa[1];
            Kurs kurs = new Kurs("Cybersecurity", 600, new Osoba("Ipp.","Sec"),group);
            kurs.printData();

        }
    }
}
