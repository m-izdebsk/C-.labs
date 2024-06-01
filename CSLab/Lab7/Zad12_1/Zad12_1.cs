/*
 
Ćwiczenie nr 7

Typy generyczne

XII.1. Kod bazowy: nowy projekt
Zbuduj klasę Stos o podawanym typie elementów stosu. Klasa powinna mieć dwa pola: tablicę przechowującą elementy oraz indeks
elementu „na szczycie” stosu. Należy też zaimplementować klasyczne metody stosu: push(element) – dodaje element na stos, pop() – 
zdejmuje element ze stosu, właściwość Top (tylko do odczytu) – podaje wartość elementu „na szczycie”.
Przetestuj działanie stosu dla kilku różnych typów elementów.


 */

using System.Diagnostics;

namespace CSLab.Lab7.Zad12_1
{
    internal class Zad12_1
    {
        public void main(string[] args) {
            var stos = new Stos<string>();
            stos.push("test1");
            stos.push("test2");
            stos.push("test3");

            Debug.Assert(stos.top() == "test3");
            Debug.Assert(stos.pop() == "test3");
            var stos2 = new Stos<int>();
            stos2.push(1);
            stos2.push(2);
            stos2.push(3);
            Debug.Assert(stos2.pop() == 3);
       
            
        }
    }
}
