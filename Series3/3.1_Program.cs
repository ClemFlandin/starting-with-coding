using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un nombre != 0 ");
            string nombreStr = Console.ReadLine();
            int nombre = Convert.ToInt32(nombreStr);
            if (nombre>0)
                Console.WriteLine("Votre nombre est positif!");
            else
                Console.WriteLine("Votre nombre est négatif!");
        }
    }
}
