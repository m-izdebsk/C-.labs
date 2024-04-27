using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._1
{/*
III.1.  Kod bazowy w projekcie klasy 2_1
    a. Oznacz pola imie i nazwisko z klasy Osoba jako prywatne zapewniając do nich publiczny dostęp poprzez odpowiednie właściwości. 
    b. Dodaj do klasy właściwość ‘Bmi’, która będzie podawać wartość wskaźnika BMI danej osoby.*/
    class Osoba
    {
        private string Imie;
        private string Nazwisko;
        private double Bmi;
        public Osoba(string imie, string nazwisko,double Bmi) {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Bmi = Bmi;
        }

        public string getImie() {
            return this.Imie;
        }
        public string getNazwisko() {
            return this.Nazwisko;
        }


    }
}
