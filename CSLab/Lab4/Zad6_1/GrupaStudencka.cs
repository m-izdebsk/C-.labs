using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab4.Zad6_1
{
    class GrupaStudencka
    {
        public struct Potok
        {
            private string Kierunek;
            private string Forma;
            private string Rodzaj;
            private string Kod;
            private int RokRozpoczecia;
            public Potok(string kierunek, string forma, string rodzaj,

                            string kod, int rokRozpoczecia)
            {

                Kierunek = kierunek;
                Forma = forma;
                Rodzaj = rodzaj;
                Kod = kod;
                RokRozpoczecia = rokRozpoczecia;
            }



            public string GenerujKodGrupy()
            {
                return $"{Kierunek}/{Forma}/{Rodzaj}/{Kod} {RokRozpoczecia}/{RokRozpoczecia + 1}";
            }
        }

            public void WypiszKodGrupy()
            {
                Potok potok = new Potok("INF", "D", "INŻ", "A", 2009);
                Console.WriteLine("Kod grupy: " + potok.GenerujKodGrupy());
            }
        }
}
