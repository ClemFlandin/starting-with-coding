using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algortihmique_Exercice8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] X = new int[1, 2];
            int val = 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    X[i, j] = val;
                    val = val + 1;
                }
            }
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("{0} ", X[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
