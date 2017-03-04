using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] t = new int[3, 1];
            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 1; m++)
                {
                    t[k, m] = (k+1) + 4*m;
                }
            }
            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 1; m++)
                {
                    Console.WriteLine(t[k, m]);
                }
            }
        }
    }
}
