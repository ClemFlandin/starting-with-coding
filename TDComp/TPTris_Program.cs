using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_23_TP_tris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 534, 354, 528, 97, 5454 , 4554 , 2, 45, 29, 100 };
            TriRapide(tab, 0, tab.Length-1);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static void TriInsertion(int[] tableau)
        {
            int longueurTab = tableau.Length;
            for (int i = 0; i < longueurTab; i++)
            {
                for (int j = i + 1; j < longueurTab; j++)
                {
                    if (tableau[i] > tableau[j])
                    {
                        int temp = tableau[j];
                        tableau[j] = tableau[i];
                        tableau[i] = temp;
                    }
                }
            }
        }

        static void TriBulles(int[] tableau)
        {
            bool yAPermute = false;
            while (!yAPermute)
            {
                yAPermute = true;
                for (int i = 0; i < tableau.Length - 1; i++)
                {
                    if (tableau[i] > tableau[i + 1])
                    {
                        int temp = tableau[i];
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = temp;
                        yAPermute = false;
                    }
                }
            }
        }

        static void TriRapide(int[] tableau, int premierDuTab, int dernierDuTab, int longueurTab)
        {
            while (Classe(tableau))
            {
                int pivot = dernierDuTab;
                int[] tabInf = new int[longueurTab];
                int[] tabSup = new int[longueurTab - 1];
                int c1 = 0, c2 = 0;
                for (int i = 0; i < longueurTab - 1; i++)
                {
                    if (tableau[i] <= pivot)
                    {
                        tabInf[c1] = tableau[i];
                        c1++;
                    }
                    else
                    {
                        tabSup[c2] = tableau[i];
                        c2++;
                    }
                }
                tabInf[c1] = pivot;
                int[] tabInfDef = new int[c1 + 1];
                for (int i = 0; i < c1 + 1; i++)
                {
                    tabInfDef[i] = tabInf[i];
                }
                int[] tabSupDef = new int[c2];
                for (int i = 0; i < c2; i++)
                {
                    tabSupDef[i] = tabSup[i];
                }
                for (int i = 0; i < c1 + 1; i++)
                {
                    tableau[i] = tabInfDef[i];
                }
                for (int i = c1 + 1; i < longueurTab; i++)
                {
                    tableau[i] = tabSupDef[i - (c1 + 1)];
                }
                premierDuTab = tableau[0];
                dernierDuTab = tableau[longueurTab - 1];
                TriRapide(tableau, premierDuTab, dernierDuTab, longueurTab);
            }
        }

        static bool Classe(int[] tableau)
        {
            bool classe = false;
            int i = 0;
            while (tableau[i] <= tableau[i + 1] && i < tableau.Length)
            {
                classe = true;
                i++;
            }
            return classe;
        }

        static void Echanger(int[] tableau, int a, int b)
        {
            int temp = tableau[a];
            tableau[a] = tableau[b];
            tableau[b] = temp;
        }

        static int Partitionner (int[] tableau, int premier, int dernier)
        {
            int j = -1;
            for (int i = 0; i < dernier; i++)
            {
                if (tableau[i] <= tableau[dernier])
                {
                    j++;
                    Echanger(tableau, i, j);
                }
            }
            j++;
            Echanger(tableau, j, dernier);
            return j;
        }

        static void TriRapide (int[] tableau, int premier, int dernier)
        {
            if (premier<dernier)
            {
                int pivot = Partitionner(tableau, premier, dernier);
                TriRapide(tableau, premier, pivot - 1);
                TriRapide(tableau, pivot + 1, dernier);
            }
        }

        static void TriFusion(int[] tableau)
        {

        }
        static void Fusion(int[] tab1, int[] tab2)
        {
            int d1 = 0;
            int f1 = tab1.Length - 1;
            int d2 = 0;
            int f2 = tab2.Length - 1;
            int k = -1;
            while (d1<=f1 && d2<=f2)
            {
                if(tab1[d1]<tab2[d2])
                {

                }
            }
        }
        https://algo.developpez.com/sources/?page=tri
    }
}
