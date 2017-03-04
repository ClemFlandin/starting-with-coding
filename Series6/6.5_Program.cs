using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[6];
            n[0] = 1;
            for (int k = 1; k < 6; k++)
            {
                n[k] = n[k - 1] + 2;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
