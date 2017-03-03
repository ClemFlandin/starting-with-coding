using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un nombre! : ");
            string nombreStr = Console.ReadLine();
            int nombre = Convert.ToInt32(nombreStr);
            if(nombre==0)
                Console.WriteLine("Votre nombre est nul!");
            else
                if(nombre<0)
                    Console.WriteLine("Votre nombre est négatif!");
                else
                    Console.WriteLine("Votre nombre est positif!");    
        }
    }
}
