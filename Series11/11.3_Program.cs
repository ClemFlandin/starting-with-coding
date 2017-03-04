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
            Console.WriteLine("Rentrez la phrase : ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Rentrez la chaine à trouver");
            string chaine = Console.ReadLine();
            int res = Trouve(phrase, chaine);
            Console.WriteLine("La chaine _{0}_ se trouve {1} fois dans la phrase : {2}", chaine, res, phrase);
        }

        static int Trouve (string phrase, string chaine)
        {
            int i = 0, trouve=0;
            while (i < phrase.Length-chaine.Length)
            {
                if (phrase.Substring(i, chaine.Length) == chaine)
                {
                    trouve++;
                }
                i++;
            }
            return trouve;
        }
    }
}
