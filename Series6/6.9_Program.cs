using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valeurs = {3, 8, 9};
            int somme = 0;
            for (int i = 0; i < valeurs.Length; i++)
            {
                somme += valeurs[i];
            }
            Console.WriteLine(somme);
        }
    }
}
