using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer deux nombres!");
            string[] nombres = Console.ReadLine().Split();
            int nombre1 = int.Parse(nombres[0]);
            int nombre2 = int.Parse(nombres[1]);
            if ((nombre1 > 0 && nombre2 > 0) || (nombre1 < 0 && nombre2 < 0))
                Console.WriteLine("Le produit de vos deux nombres sera positif!");
            else
                if ((nombre1 > 0 && nombre2 < 0) || (nombre1 < 0 && nombre2 > 0))
                    Console.WriteLine("Le produit de vos deux nombres sera négatif!");
                else
                    Console.WriteLine("Le produit de vos deux nombres sera nul!");
        }
    }
}
