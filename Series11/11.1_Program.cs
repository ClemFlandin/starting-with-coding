using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_18_Algorithmique_Exercice11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer 5 nombres entiers");
            string[] nombres = Console.ReadLine().Split();
            int nombre1 = Convert.ToInt32(nombres[0]);
            int nombre2 = Convert.ToInt32(nombres[1]);
            int nombre3 = Convert.ToInt32(nombres[2]);
            int nombre4 = Convert.ToInt32(nombres[3]);
            int nombre5 = Convert.ToInt32(nombres[4]);
            int somme = Somme5Entiers(nombre1, nombre2, nombre3, nombre4, nombre5);
            Console.WriteLine("La somme des 5 nombres rentrés vaut {0}", somme);
        }

        static int Somme5Entiers ( int entier1, int entier2, int entier3, int entier4, int entier5)
        {
            int somme = entier1 + entier2 + entier3 + entier4 + entier5;
            return somme;
        }
    }
}
