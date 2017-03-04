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
            Console.WriteLine("Rentrez vos caractères à effacer dans la phrase : ");
            string caracteresAEffacer = Console.ReadLine();
            string nouvellePhrase = Purge(phrase, caracteresAEffacer);
            Console.WriteLine("Voici votre nouvelle phrase : \n\t {0}", nouvellePhrase);
        }

        static string Purge(string phrase, string caracteresAEffacer)
        {
            foreach (char caractereAEffacer in caracteresAEffacer)
            {
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[i] == caractereAEffacer)
                    {
                        phrase = phrase.Remove(i, 1);
                        i--;
                    }
                }
            }
            return phrase;
        }
    }
}
