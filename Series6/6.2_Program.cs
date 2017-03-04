using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] voyelles = new char[6];
            voyelles[0] = 'a';
            voyelles[1] = 'e';
            voyelles[2] = 'i';
            voyelles[3] = 'o';
            voyelles[4] = 'u';
            voyelles[5] = 'y';
            for (int i = 0; i < voyelles.Length; i++)
            {
                Console.WriteLine(voyelles[i]);
            }
        }
        //Variante : char[] voyelles = new char {'a', 'e', 'i', 'o', 'u', 'y'};
    }
}
