using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_Algorithmique_Exercice9_8
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
                if (lettre == ' ')
                {
                    temp = temp + lettre;
                }
                else
                {
                    char nouvelleLettre = NouvelleLettre(lettre);
                    temp = temp + nouvelleLettre;
                }
            }
            phrase = temp;
            Console.WriteLine("Voici la phrase cryptée : ");
            Console.WriteLine(phrase);
               
        }

        static char NouvelleLettre(char lettre)
        {
            char[] nouvelAlphabet = { 'H', 'Y', 'L', 'U', 'J', 'P', 'V', 'R', 'E', 'A', 'K', 'B', 'N', 'D', 'O', 'F', 'S', 'Q', 'Z', 'C', 'W', 'M', 'G', 'I', 'T', 'X' };
            char nouvelleLettre;
            int asciiNouvelleLettre;
            asciiNouvelleLettre = nouvelAlphabet[lettre - 65];
            nouvelleLettre = Convert.ToChar(asciiNouvelleLettre);
            return nouvelleLettre;
        }
    }
}
