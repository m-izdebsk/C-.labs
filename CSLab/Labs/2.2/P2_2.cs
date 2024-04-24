using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Dla podanego tekstu utwórz tablicę zawierającą słowa z tego tekstu.
//Znaki białe oraz interpunkcyjne nie wchodzą w skład żadnego słowa.
namespace CSLab
{
    internal class P2_2
    {
        public void main(string[] args) {
            string line = Console.ReadLine();
            line = Regex.Replace(line, "[^a-zA-Z0-9\\:_\\- ]", "");
            string[] words =  line.Split();
            foreach (var item in words)
            {
                Console.Write(item+"   ");
            }

        }
    }
}
