using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "belle marquise, ", b = "vos beaux yeux ", c = "me font mourir ", d = "d'amour ";
            string A = a + b + c + d, B = b + c + a + d, C = d + a + c + b, D = d + c + a + b;
            Console.WriteLine("Première version : {0},\n Deuxième version : {1},\n Troisième version : {2},\n Quatrième version : {3} ", A, B, C, D);
        }
    }
}
