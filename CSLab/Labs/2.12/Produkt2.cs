using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*II.6 (nowy projekt ‘produkt’)
Utwórz klasę o nazwie Produkt.

Zaimplementuj konstruktor klasy (przekazujący wartości do pól) oraz metodę wypisującą dane produktu na konsolę.
Zaimplementuj konstruktor tworzący obiekt w oparciu o wartości podane z konsoli.
Zaimplementuj metodę Clone() tworzącą kopię obiektu.
Przetestuj zaimplementowane składowe pisząc odpowiedni kod testowy w metodzie Main().
*/
namespace CSLab.Labs._2._12
{  
    public class Produkt2
    {
        string nazwa;
        float cena;
        string jednostkaMiary;
        DateTime dataZakupu;
        float VAT;


        public Produkt2(string nazwa, float cena, string jednostka, DateTime dataZakupu, float vat)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.jednostkaMiary = jednostka;
            this.dataZakupu = dataZakupu;
            this.VAT = vat;
        }
        public override string ToString() {
            return "Nazwa: "+this.nazwa+"\nCena:"+this.cena+"\nj.m.:"+this.jednostkaMiary+"\nData zakupu:"+this.dataZakupu+"\nVAT:"+this.VAT;
        }
        public void printData() {
            Console.WriteLine(this);
        }
        public Produkt2 readDataFromKeyboard() {
            Console.WriteLine("Podaj nazwe:");
            string nazwa = Console.ReadLine();
            
            Console.WriteLine("Podaj cene:");
            float cena = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj jednostke miary:");
            string jm = Console.ReadLine();
            
            Console.WriteLine("Podaj date zakupu w formacie: yyyy-MM-dd mm:HH:ss");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj vat:");
            float vat = float.Parse(Console.ReadLine());
            return new Produkt2(nazwa, cena, jm, date, vat);
        }
        public Produkt2 clone() {
            return new Produkt2(this.nazwa, this.cena, this.jednostkaMiary, this.dataZakupu, this.VAT);
        }
    }
}
