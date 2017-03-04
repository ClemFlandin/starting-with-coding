using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionnaire = { "amour", "argent", "boulet", "chouchou"};
            Console.WriteLine("Veuillez rentrer un mot! ");
            string mot = Console.ReadLine();
            bool estDansLeDico = true;
            int i = 0;
            do
            {
                i++;
            } while (mot != dictionnaire[i-1] && i<dictionnaire.Length);
            if (i == dictionnaire.Length)
            {
                estDansLeDico = false;
            }
            Console.WriteLine(estDansLeDico);
        }
    }
}
