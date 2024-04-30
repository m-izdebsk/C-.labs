using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Narzedzia.Zad2
{
    class Grupa
    {
        public string Nazwa;
        public int rozmiar;
        public Osoba[] czlonkowie = new Osoba[0];
        public Grupa(string nazwa)
        {
            Nazwa = nazwa;
            rozmiar = 0;
        }
        public void dodajCzlonka(Osoba czlonek)
        {
            Osoba[] destinationArray = new Osoba[czlonkowie.Length + 1];
            Array.Copy(czlonkowie, destinationArray, czlonkowie.Length);
            destinationArray[czlonkowie.Length] = czlonek;
            czlonkowie = destinationArray;
            Console.WriteLine(czlonkowie.Length);
            rozmiar++;
        }
        public void usunCzlonka(Osoba czlonek)
        {

            for (int i = 0; i < czlonkowie.Length; i++)
            {
                if (czlonkowie[i] == czlonek)
                {
                    usunCzlonka(i);
                    break;
                }

            }

        }
        public void usunCzlonka(int czlonek)
        {
            if (czlonek < czlonkowie.Length)
            {
                Osoba removed = czlonkowie[czlonek];

                //przesun czlonka
                for (int i = czlonek; i < czlonkowie.Length; i++)
                {
                    czlonkowie[i - 1] = czlonkowie[i];
                }

            }


        }

    }
}
