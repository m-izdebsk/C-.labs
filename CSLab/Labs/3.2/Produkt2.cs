using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
III.2 Kod bazowy w projekcie ‘produkt’
W klasie Produkt:
    a. Zdefiniuj właściwości dające publiczny dostęp do pól: nazwa produktu, jednostka miary i cena zakupu.
    b. Zdefiniuj właściwość CenaDetaliczna obliczająca cenę po której będzie sprzedawany produkt. 
    c. Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]

*/
namespace CSLab.Labs._3._2
{
    public class Produkt2
    {
        private string nazwa;
        private float cena;
        //Zdefiniuj właściwość CenaDetaliczna obliczająca cenę po której będzie sprzedawany produkt.
        private float cenaDetaliczna;
        private string jednostkaMiary;
        DateTime dataZakupu;
        float VAT;


        public Produkt2(string nazwa, float cena, string jednostka, DateTime dataZakupu, float vat)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.jednostkaMiary = jednostka;
            this.dataZakupu = dataZakupu;
            this.VAT = vat;
            this.cenaDetaliczna = this.cena + this.cena * (this.VAT / 100);
        }
        private object getValueByName(string propertyName)
        {
            FieldInfo fieldInfo = typeof(Produkt2).GetField(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                return fieldInfo.GetValue(this);
            }
            else
            {
                throw new ArgumentException($"Wartosc '{propertyName}' nie istnieje");
            }
        }
        //Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]
        public object this[string propertyName]
        {
            get
            {
                return getValueByName(propertyName);
            }
        }
        public string getByName(string name) {
            string value = "";



            return value;        
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
