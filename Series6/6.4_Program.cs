using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nb = new int[5];
            for (int i = 0; i < 5; i++)
            {
                nb[i] = i * i;
                Console.WriteLine(nb[i]);
            }
        }
    }
}
