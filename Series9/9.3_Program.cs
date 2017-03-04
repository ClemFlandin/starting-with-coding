using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer une phrase !");
            string phrase = Console.ReadLine();
            int nbreEspaces = 0;
            char espace = ' ';
            foreach (char esp in phrase)
            {
                if(esp==espace)
                {
                    nbreEspaces++;
                }
            }
            int nbreMots = nbreEspaces + 1;
            Console.WriteLine(nbreMots);
        } 
    }
}
