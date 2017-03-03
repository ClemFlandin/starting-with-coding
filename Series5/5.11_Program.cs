using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer le nombre de chevaux partants!");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);
            Console.WriteLine("Veuillez rentrer le nombre de chevaux joués!");
            string pStr = Console.ReadLine();
            int p = Convert.ToInt32(pStr);
            double X = 0, Y = 0;
            int factn = 1;
            for (int i = 1; i < n+1; i++)
            {
                factn *= i;
            }
            int factp = 1;
            for (int i = 1; i < p+1 ; i++)
            {
                factp *= i;
            }
            int factnMoinsp = 1;
            for (int i = 1; i < (n- p)+1; i++)
            {
                factnMoinsp *= i;
            }
            X = factn / factnMoinsp;
            Y = factn / (factp * factnMoinsp);
            Console.WriteLine("Vous avez une chance sur {0} de  gagner dans en jouant dans l'ordre et une chance sur {1} dans le désordre!", X, Y);
        }
    }
}
