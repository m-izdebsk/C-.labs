using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Spr1.Cw1
{
    internal class Sprawdzian1
    {
        public void main(string[] args) {
            Console.WriteLine("Sprawdzian 1");

            List<Student> students = new List<Student>();

            students.Add(new Student("Maksymilian I."));
            students.Add(new Student("Pan Tadeusz"));
            students.Add(new Student("Kordian"));

            students.Sort();
            foreach (Student student in students)
            {
                student.Opisz();
            }
        }
    }
}
