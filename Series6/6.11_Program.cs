using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_11_Algorithmique_Exercice6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 4, 8, 7, 12 };
            int[] tab2 = { 3, 6 };
            int toon = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab2.Length; j++)
                {
                    toon += tab1[i]*tab2[j];
                }
            }
            Console.WriteLine(toon);
        }
    }
}
