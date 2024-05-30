using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Lab5.Zad8_2;

internal class Zad8_2
{
    public void main(string[] args)
    {
        //konwersja jawna:
        Pracownik studentPrac = (Pracownik)new Student("Max", "Kolonko");
        Debug.Assert(studentPrac is Pracownik);

        //konwersja niejawna 
        Student studPrac = new Pracownik("Jestem", "Studentem");
        Debug.Assert(studPrac is Student);
    }
}
