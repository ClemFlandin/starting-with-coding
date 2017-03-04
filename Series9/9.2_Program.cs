using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un mot!");
            string mot = Console.ReadLine();
            int longueurMot = mot.Length;
            Console.WriteLine("Votre mot compte : {0} lettres! ", longueurMot);
        }
    }
}
