using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_Algorithmique_Exercice9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valeur aléatoire entre 0 et 2 ! ");
            Random random1 = new Random();
            int glup1 = random1.Next(2);
            Console.WriteLine(glup1);

            Console.WriteLine("Valeur aléatoire entre -1 et 1 ! ");
            Random random2 = new Random();
            int glup2 = random2.Next(-1, 1);
            Console.WriteLine(glup2);

            Console.WriteLine("Emule un dé à 6 faces ! ");
            Random random3 = new Random();
            int glup3 = random3.Next(1,6);
            Console.WriteLine(glup3);

            Console.WriteLine("Valeur aléatoire entre -10.5 et 6.5 ! ");
            Random random4 = new Random();
            double glup4 = random4.Next(-105, 65);
            Console.WriteLine(glup4);
            glup4 = glup4 / 10.0;
            Console.WriteLine(glup4);

            Console.WriteLine("Emule la somme de deux dés à 6 faces ! ");
            Random random5 = new Random();
            int glup5 = random5.Next(1, 6);
            Console.WriteLine(glup5);
            Random random5bis = new Random();
            int glup5bis = random5bis.Next(1,6);
            Console.WriteLine(glup5bis);
            Console.WriteLine(glup5 + glup5bis);
        }
    }
}
