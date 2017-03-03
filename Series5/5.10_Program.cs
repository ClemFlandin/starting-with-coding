using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_12_Algorithmique_Exercice5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;
            string[] prixStr = Console.ReadLine().Split();
            for (int i = 0; i < prixStr.Length; i++)
            {
                somme += Convert.ToInt32(prixStr[i]);
            }
            Console.WriteLine("Vous nous devez : {0}", somme);
            int temp = 0;
            int billets10 = somme / 10;
            temp = somme % 10;
            int billets5 = temp / 5;
            temp %= 5;
            int pieces1 = temp;
            Console.WriteLine("Veuillez donner {0} billets de 10, {1} billet de 5 et {2} pièces de 1!", billets10, billets5, pieces1);
        }
    }
}
