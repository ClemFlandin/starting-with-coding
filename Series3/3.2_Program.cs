using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un deux nombres ! ");
            string[] nombres = Console.ReadLine().Split();
            int nombre1 = int.Parse(nombres[0]);
            int nombre2 = int.Parse(nombres[1]);
            if((nombre1 > 0 && nombre2 > 0) || (nombre1 < 0 && nombre2 < 0))
                Console.WriteLine("Le produit de vos deux nombres sera positif");
            else
                Console.WriteLine("Le produit de vos deux nombres sera négatif");
        }
    }
}
// Dans la console Windows entre les deux nombres séparés d'un espace PUIS faire "entrée"