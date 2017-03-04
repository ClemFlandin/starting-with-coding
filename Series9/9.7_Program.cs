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
            Console.WriteLine("Veuillez rentrer le décalage! ");
            string decalageStr = Console.ReadLine();
            string temp = null;
            int decalage = Convert.ToInt16(decalageStr);
            foreach (char lettre in phrase)
            {
                char nouvelleLettre = NouvelleLettre(lettre, decalage);
                temp = temp + nouvelleLettre;
            }
            phrase = temp;
            Console.WriteLine(phrase);
        }

        static char NouvelleLettre(char lettre, int decalage)
        {
            char nouvelleLettre;
            int asciiNouvelleLettre = lettre + decalage;
            if (asciiNouvelleLettre <= 90)
            {
                nouvelleLettre = Convert.ToChar(asciiNouvelleLettre);
            }
            else
            {
                asciiNouvelleLettre = asciiNouvelleLettre - 26;
                nouvelleLettre = Convert.ToChar(asciiNouvelleLettre);
            }
            return nouvelleLettre;
        }
    }
}
