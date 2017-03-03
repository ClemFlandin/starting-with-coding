using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_10_Algorithmique_Exercice4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez les scores des candidats");
            string[] scores = Console.ReadLine().Split();
            int i = 0;
            int scorePremierCandidat = Convert.ToInt32(scores[0]);
            while (i < 3)
            {

                if (String.Compare(scores[i], scores[i + 1]) == 1)
                {
                    string temp;
                    temp = scores[i];
                    scores[i] = scores[i + 1];
                    scores[i + 1] = temp;
                }
                i++;

            }
            int dernierScore = Convert.ToInt32(scores[3]);
            if (dernierScore == scorePremierCandidat)
            {
                if (scorePremierCandidat > 50)
                {
                    Console.WriteLine("Le candidat numéro 1 est élu au premier tour!");
                }
                else
                {
                    Console.WriteLine("Le candidat numéro 1 est en ballottage favorable!");
                }
            }
            else if (scorePremierCandidat >= 12.5)
            {
                Console.WriteLine("Le candidat numéro 1 est en ballottage défavorable!");
            }
            else
            {
                Console.WriteLine("Le candidat numéro 1 est battu au premier tour!");
            }

        }
    }
}
