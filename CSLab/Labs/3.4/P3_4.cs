using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._4
{
    internal class P3_4
    {
        public void main(string[] args)
        {
            //tworzymy wektor
            Wektor wektor = new Wektor(3,[1,2,3]);
            //testowanie indekstatora
            Debug.Assert(wektor[0] == 1);
            Debug.Assert(wektor[1] == 2);
            Debug.Assert(wektor[2] == 3);

        }
    }
}
