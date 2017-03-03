using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer votre âge et votre sexe : ");
            string[] informations = Console.ReadLine().Split();
            int age = Convert.ToInt32(informations[0]);
            string sexe = informations[1];

            if (sexe == "homme")
            {
                if (age > 20)
                {
                    Console.WriteLine("Vous êtes imposable!");
                }
                else
                {
                    Console.WriteLine("Vous n'êtes pas imposable!");
                }
            }
            else
            {
                if (age >= 18 && age < 35)
                {
                    Console.WriteLine("Vous êtes imposable!");
                }
                else
                {
                    Console.WriteLine("Vous n'êtes pas imposable!");
                }
            }
        }
    }
}
