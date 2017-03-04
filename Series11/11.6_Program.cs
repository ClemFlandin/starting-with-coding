using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_18_Algortihmique_Exercice11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 15, 5, 56, 24, 13 };
            tableau = TriTableau(tableau, tableau.Length);
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }

        static int[] TriTableau(int[] tableau, int longueurTableau)
        {
            for (int i = 0; i < longueurTableau-1; i++)
            {
                for (int j = i; j < longueurTableau; j++)
                {
                    if (tableau[i] > tableau[j])
                    {
                        int temp = tableau[j];
                        tableau[j] = tableau[i];
                        tableau[i] = temp;
                    }
                }
            }
            return tableau;
        }
    }
}
