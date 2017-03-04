using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_20_Algorithmique_Exercice11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableau = new int[9, 9];
            do
            {
                tableau = RemplitGrille(tableau);
            } while (!VerifLignes(tableau) && !VerifColonnes(tableau) && !VerifSousGrilles(tableau)) ;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(tableau[i,j]);
                }
                Console.WriteLine();
            }
        }

        static bool TousDifferents(int[] tableau)
        {
            bool tousDifferents = true;
            for (int i = 0; i < tableau.Length-1; i++)
            {
                for (int j = i+1; j < tableau.Length; j++)
                {
                    if (tableau[i]==tableau[j])
                    {
                        tousDifferents = false;
                    }
                }
            }
            return tousDifferents;
        }

        static int[,] RemplitGrille(int[,] tableau)
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tableau[i, j] = random.Next(1, 9);
                }
            }
            return tableau;
        }

        static bool VerifLignes (int[,] tableau)
        {
            bool[] verifLigne= new bool[9];
            bool diff = true;
            for (int i = 0; i < 9; i++)
            {
                int[] tab = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    tab[i] = tableau[i, j];
                    verifLigne[i] = TousDifferents(tab);
                }
            }
            int k = 0;
            while (verifLigne[k])
            {
                k++;
            } 
            if(k!=9)
            {
                diff = false;
            }
            return diff;
        }

        static bool VerifColonnes(int[,] tableau)
        {
            bool[] verifColonne = new bool[9];
            bool diff = true;
            for (int i = 0; i < 9; i++)
            {
                int[] tab = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    tab[i] = tableau[j, i];
                    verifColonne[i] = TousDifferents(tab);
                }
            }
            int k = 0;
            while (verifColonne[k]) 
            {
                k++;
            } 
            if (k != 9)
            {
                diff = false;
            }
            return diff;
        }

        static bool VerifSousGrilles(int[,] tableau)
        {
            bool[] verifSousGrille = new bool[9];
            bool verif = true;
            int[] tab = new int[9];
            if (VerifLignes(tableau) && VerifColonnes(tableau))
            for (int i = 0; i < 6; i+=3)
            {
                for (int j = 0; j < 6; j+=3)
                {
                        int[,] sousGrille = new int[3, 3];
                        for (int k = 0; k < 2; k++)
                        {
                            for (int l = 0; l < 2; l++)
                            {
                                sousGrille[k * 3, l] = tableau[i + k, j + l];
                                tab[i] = sousGrille[k * 3, 1];
                                if (TousDifferents(tab))
                                {
                                    verifSousGrille[k * 3 + l] = true;
                                }

                            }
                        }
                }
            }
            int verifSG = 0;
            while (verifSousGrille[verifSG]) 
            {
                verifSG++;
            } 
            if(verifSG != 9)
            {
                verif = false;
            }
            return verif;
        }
    }
}
