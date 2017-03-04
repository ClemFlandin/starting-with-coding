using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableau = new int[6, 13];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    tableau[i, j] = 0;
                    Console.Write("{0} ", tableau[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
