using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] T = new int[12,8];
            Random random = new Random();
            int max = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int val = random.Next(100);
                    if (val>max)
                    {
                        max = val;
                    }
                    T[i, j] = val;
                    Console.Write("{0} ", T[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);
        }
    }
}
