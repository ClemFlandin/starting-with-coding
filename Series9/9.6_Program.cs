using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer une phrase!");
            string phrase = Console.ReadLine();
            string temp = null;
            foreach (char lettre in phrase)
            {
                char nouvelleLettre = NouvelleLettre(lettre);
                temp = temp + nouvelleLettre;
            }
            phrase = temp;
            Console.WriteLine(phrase);

        }

        static char NouvelleLettre(char lettre)
        {
            char nouvelleLettre;
            if (lettre == 90)
            {
                nouvelleLettre = 'A';
            }
            else
            {
                nouvelleLettre = Convert.ToChar(lettre + 1);
            }
            return nouvelleLettre;
        }
    }
}
