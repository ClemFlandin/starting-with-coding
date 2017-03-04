using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] suite = new int[7];
            suite[0] = 1;
            suite[1] = 1;
            for (int i = 2; i < 7; i++)
            {
                suite[i] = suite[i - 1] + suite[i - 2];
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(suite[i]);
            }
        }
    }
}
