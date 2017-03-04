using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer une phrase !");
            string phrase = Console.ReadLine();
            int occurrenceA = OccurrenceVoyelle(phrase, 'a');
            int occurrenceE = OccurrenceVoyelle(phrase, 'e');
            int occurrenceI = OccurrenceVoyelle(phrase, 'i');
            int occurrenceO = OccurrenceVoyelle(phrase, 'o');
            int occurrenceU = OccurrenceVoyelle(phrase, 'u');
            int occurrenceY = OccurrenceVoyelle(phrase, 'y');
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", occurrenceA, occurrenceE, occurrenceI, occurrenceO, occurrenceU, occurrenceY);
            int occurrenceVoyelles = occurrenceA + occurrenceE + occurrenceI + occurrenceO + occurrenceU + occurrenceY;
            Console.WriteLine("Votre phrase comporte {0} voyelles! ", occurrenceVoyelles);

        }

        static int OccurrenceVoyelle(string phrase, char voyelle)
        {
            int occurrence = 0;
            foreach (char lettre in phrase)
            {
                if (lettre == voyelle)
                {
                    occurrence++;
                }
            }
            return occurrence;
        }
    }
}
