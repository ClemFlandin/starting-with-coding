using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 15, 23, 45, 8, 32};
            int longueur = tableau.Length, temp=0;
            for (int i = 0; i < longueur/2; i++)
            {
                temp = tableau[longueur - i-1];
                tableau[longueur-i-1] = tableau[i];
                tableau[i] = temp;
                Console.WriteLine(tableau[i]);
            }
            for (int j = longueur / 2; j < longueur; j++)
            {
                Console.WriteLine(tableau[j]);
            }
        }
    }
}
