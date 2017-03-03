using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_10_Algorithmique_Exercice4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer l'age du conducteur, la durée de possession du permis, le nombre d'accidents responsables ainsi que l'ancienneté!");
            string[] parametres = Console.ReadLine().Split();
            int age = Convert.ToInt32(parametres[0]);
            int dureePermis = Convert.ToInt32(parametres[1]);
            int nbreAccidents = Convert.ToInt32(parametres[2]);
            int anciennete = Convert.ToInt32(parametres[3]);
            string catTarif = "refusé";

            if ((age < 25 && dureePermis < 2 && nbreAccidents==0) || (dureePermis < 2 && nbreAccidents==1) || (dureePermis > 2 && nbreAccidents == 2))
            {
                catTarif = "rouge";
            }

            if ((age < 25 && dureePermis > 2 && nbreAccidents == 0) || (age >= 25 && dureePermis < 2 && nbreAccidents == 1)) 
            {
                catTarif = "orange";
            }

            if (age >= 25 && nbreAccidents == 0)
            {
                catTarif = "vert";
            }
            if (anciennete > 5)
            {
                if (catTarif == "rouge")
                {
                    catTarif = "orange";
                }
                else if (catTarif == "orange")
                {
                    catTarif = "vert";
                }
                else if (catTarif== "vert")
                {
                    catTarif = "bleu";
                }
            }
            Console.WriteLine("Tarif : {0}", catTarif);
        }
    }
}
