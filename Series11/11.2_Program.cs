using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_18_Algorithmique_Exercice11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez votre phrase : ");
            string phrase = Console.ReadLine();
            int voyelles = NombreVoyelles(phrase);
            Console.WriteLine("Votre phrase comporte {0} voyelles !", voyelles);
        }

        static int NombreVoyelles (string chaine)
        {
            int voyelles = 0;
            foreach (char lettre in chaine)
            {
                if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u' || lettre == 'y')
                {
                    voyelles++;
                }
            }
            return voyelles;
        }
    }
}
