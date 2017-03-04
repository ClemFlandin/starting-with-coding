using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_12_Algorithmique_Exercice6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[100];
            bool consecutifs = true;
            for (int i = 0; i < 100; i++)
            {
                tableau[i] = i * 3;
            }
            int j = 0;
            while (tableau[j] + 1 ==tableau[j+1] && j < 98)
            {
                j++;
            }
            if (j != 98)
            {
                consecutifs = false;
            }
            Console.WriteLine(consecutifs);
        }
    }
}
