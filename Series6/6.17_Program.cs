using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_12_Algorithmique_Exercice6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer 100(!) valeurs ! ");
            int[] tableau = new int[100];
            for (int i = 0; i < 100; i++)
            {
                string valeurStr = Console.ReadLine();
                int valeur = Convert.ToInt32(valeurStr);
                tableau[i] = valeur;
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}
