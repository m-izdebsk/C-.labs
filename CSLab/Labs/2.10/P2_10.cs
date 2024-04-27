using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab
{
    internal class P2_10
    {
        public void main(string[] args)
        {
            Labs.Wektor wektor = Labs.Wektor.zbudujWektor();
            wektor.show();
            Labs.Wektor randomWektor = new Labs.Wektor(4, 1.0, 2.0);
            randomWektor.show();

        }
    }
}
