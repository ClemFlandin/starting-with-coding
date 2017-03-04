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
            Console.WriteLine("Veuillez rentrer {0} valeurs!", nombre);
            int[] tableau = new int[nombre];
            bool consecutifs = true;
            for (int i = 0; i < nombre; i++)
            {
                string valeurRentree = Console.ReadLine();
                int valeur = Convert.ToInt32(valeurRentree);
                tableau[i] = valeur;
            }

            int j = 0;
            do
            {
                j++;
            } while (tableau[j - 1] + 1 == tableau[j] && j < nombre-1) ;

            if (j != nombre-1 || tableau[nombre-2] + 1 != tableau[nombre-1])
            {
                consecutifs = false;
            }
            Console.WriteLine(consecutifs);
        }
    }
}
