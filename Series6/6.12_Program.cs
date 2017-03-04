using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer le nombre de valeur que vous comptez saisir!");
            string nombreStr = Console.ReadLine();
            int nombre = Convert.ToInt32(nombreStr);
            int[] tableau = new int[nombre];
            for (int i = 0; i < nombre; i++)
            {
                string valeurRentree = Console.ReadLine();
                int valeur = Convert.ToInt32(valeurRentree);
                tableau[i] = valeur + 1;
            }
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}
