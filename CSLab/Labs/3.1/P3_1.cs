using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._1
{
    
    internal class P3_1
    {
        public void main(string[] args)
        {
            string imie = "JakiesImie";
            string nazwisko = "Nazwisko";
            double bmi = 35.0;
            //testing
            Osoba osoba = new Osoba(imie,nazwisko,bmi);
            Debug.Assert(osoba != null);
            Debug.Assert(osoba.getImie() == imie);
            Debug.Assert(osoba.getNazwisko() == nazwisko);
            Debug.Assert(osoba.getBmi() == bmi);

        }
    }
}
