using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un nombre : ");
            string nombre = Console.ReadLine();
            int nombreEnChiffres = Convert.ToInt32(nombre), carre;
            carre = nombreEnChiffres * nombreEnChiffres;
            Console.WriteLine("Le carré de {0} vaut : {1}", nombre, carre);

        }
    }
}
