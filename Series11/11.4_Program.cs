using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_18_Algorithmique_Exercice11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez votre phrase : ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Rentrez votre caractère à effacer de la phrase : ");
            string caractereAEffacerStr = Console.ReadLine();
            char caractereAEffacer = Convert.ToChar(caractereAEffacerStr);
            string nouvellePhrase = Purge(phrase, caractereAEffacer);
            Console.WriteLine("Voici votre nouvelle phrase : \n\t {0}", nouvellePhrase);
        }

        static string Purge(string phrase, char caractereAEffacer)
        {
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == caractereAEffacer)
                {
                    phrase = phrase.Remove(i, 1);
                    i--;
                }
            }
            return phrase;
        }
    }
}
