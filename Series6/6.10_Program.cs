using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_10_Algorithmique_Exercice6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 4, 8, 7, 9, 1, 5, 4, 6 };
            int[] tab2 = { 7, 6, 5, 2, 1, 3, 7, 4 };
            int[] tab = new int[8];
            for (int i = 0; i < 8; i++)
            {
                tab[i] = tab1[i] + tab2[i];
                Console.WriteLine(tab[i]);
            }
        }
    }
}
