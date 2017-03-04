using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_18_Algorithmique_Exercice11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 1, 4, 9, 30 };
            Console.WriteLine(tableau);
            bool res = TableauTrie(tableau);
            Console.WriteLine(res);
        }

        static bool TableauTrie(int[] tableau)
        {
            int longueurTableau = tableau.Length, i = 0;
            while (i < longueurTableau - 1 && tableau[i]<=tableau[i+1])
            {
                i++;
            }
            if (i==longueurTableau - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
