using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_6_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { -3, -15, -2, -8, -1 };
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
            }
            int ecartMax = 0;
            if (tableau[longueurTableau - 1] <0)
            {
                ecartMax = tableau[0] - tableau[longueurTableau - 1];
            }
            else if (tableau[longueurTableau - 1] < 0 && tableau[0] < 0)
            {
                ecartMax = -tableau[0] + tableau[longueurTableau-1];
            }
            Console.WriteLine(ecartMax);
        }
    }
}

