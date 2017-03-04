using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5, 2, 6, 8, 0 };
            Console.WriteLine("Veuillez rentrer l'indice de la valeur à supprimer! ");
            string indiceString = Console.ReadLine();
            int indice = Convert.ToInt32(indiceString);
            int[] newTab = new int[tab.Length - 1];
            for (int i = 0; i < indice; i++)
            {
                newTab[i] = tab[i];
                Console.WriteLine(newTab[i]);
            }
            for (int j = indice; j < newTab.Length; j++)
            {
                newTab[j] = tab[j + 1];
                Console.WriteLine(newTab[j]);
            }
        }
    }
}
