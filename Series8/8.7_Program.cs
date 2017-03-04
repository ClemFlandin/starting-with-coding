using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_15_Algorithmique_Exercice8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] damier = new char[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    damier[i,j]='O';
                    Console.Write("{0} ", damier[i,j]);
                }
                Console.WriteLine();
            }
            int ordonnee = 8;
            int abscisse = 8;
            while (abscisse > 7)
            {
                Console.WriteLine("Veuillez indiquer l'abscisse du pion! ");
                string abscisseStr = Console.ReadLine();
                abscisse = Convert.ToInt32(abscisseStr);
            }
            while (ordonnee > 7)
            {
                Console.WriteLine("Veuillez indiquer l'ordonnée du pion! ");
                string ordonneeStr = Console.ReadLine();
                ordonnee = Convert.ToInt32(ordonneeStr);
            }
            Console.WriteLine("Quel mouvement voulez-vous effectuer? ");
            string mouvementStr = Console.ReadLine();
            int mouvement = Convert.ToInt32(mouvementStr);
            switch (mouvement)
            {
                case 0:
                    abscisse = abscisse - 1;
                    ordonnee = ordonnee - 1;
                    if (abscisse > 7 || ordonnee > 7 || abscisse < 0 || ordonnee < 0)
                    {
                        Console.WriteLine("Mouvement Impossible!");
                    }
                    else
                    {
                        damier[abscisse, ordonnee] = 'X';
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Console.Write("{0} ", damier[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 1:
                    abscisse = abscisse - 1;
                    ordonnee = ordonnee + 1;
                    if (abscisse > 7 || ordonnee > 7 || abscisse < 0 || ordonnee < 0)
                    {
                        Console.WriteLine("Mouvement Impossible!");
                    }
                    else
                    {
                        damier[abscisse, ordonnee] = 'X';
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Console.Write("{0} ", damier[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 2:
                    abscisse = abscisse + 1;
                    ordonnee = ordonnee - 1;
                    if (abscisse > 7 || ordonnee > 7 || abscisse < 0 || ordonnee < 0)
                    {
                        Console.WriteLine("Mouvement Impossible!");
                    }
                    else
                    {
                        damier[abscisse, ordonnee] = 'X';
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Console.Write("{0} ", damier[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    abscisse = abscisse + 1;
                    ordonnee = ordonnee + 1;
                    if (abscisse > 7 || ordonnee > 7 || abscisse < 0 || ordonnee < 0)
                    {
                        Console.WriteLine("Mouvement Impossible!");
                    }
                    else
                    {
                        damier[abscisse, ordonnee] = 'X';
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Console.Write("{0} ", damier[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
