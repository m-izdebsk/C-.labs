using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad9_1
{
    internal class Zad9_1
    {
        //Zdefiniuj delegację reprezentującą funkcje o dwóch argumentach typu string i int, zwracające wynik typu string.
        public delegate string MojaDelegacja(string tekst, int liczba);

        public void main(string[] args) {
            MojaDelegacja doklej = MetodyDelegacji.DoklejLiczbe;
            MojaDelegacja powtorz = MetodyDelegacji.PowtorzString;
            MojaDelegacja poczatekZnaki = MetodyDelegacji.PoczatkoweZnaki;
            string wynik = doklej("Tekst", 123);
            Console.WriteLine(wynik);
             wynik = powtorz("Tekst", 3);
            Console.WriteLine(wynik);  
            wynik = poczatekZnaki("Tekst", 3);
            Console.WriteLine(wynik);
        }


    }
    public class MetodyDelegacji
    {
        //metoda doklejająca liczbę na końcu stringa
        public static string DoklejLiczbe(string tekst, int liczba)
        {
            return tekst + liczba.ToString();
        }

        //metoda powtarzająca string tyle razy na ile wskazuje drugi argument
        public static string PowtorzString(string tekst, int liczba)
        {
            string item="";
            for (int i = 0; i < liczba; i++) {
                item += tekst+"\n";
            }
            return item;
        }

        //metoda zwracająca początkowe znaki ze stringa (tyle ile wskazuje drugi argument)
        public static string PoczatkoweZnaki(string tekst, int liczba)
        {
            if (liczba >= tekst.Length)
                return tekst;
            else
                return tekst.Substring(0, liczba);
        }
    }


}
