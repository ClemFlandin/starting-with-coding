using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double somme = 1000.0;
            double[] fortune = new double[20];
            for (int i = 0; i < 20; i++)
            {
                somme += somme * 0.0275;
                fortune[i] = somme;
                Console.WriteLine(fortune[i]);
            }
            Console.WriteLine("Veuillez rentrer un âge : ");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            Console.WriteLine("A {0} ans, TOTO aura {1} argent sur son compte", age, fortune[age-1]);
        }
    }
}
