using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 5, 4, 9, 2, 10 };
            int longueurTableau = tableau.Length, temp = 0;
            for (int i = 0; i < longueurTableau; i++)
            {
                for (int j = i + 1; j < longueurTableau; j++)
                {
                    if (tableau[i] < tableau[j])
                    {
                        temp = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = temp;
                    }
                }
                Console.WriteLine(tableau[i]);
            }

        }
    }
}
