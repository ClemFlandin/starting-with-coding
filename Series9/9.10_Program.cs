using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_Algorithmique_Exercice9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un nombre! ");
            string nombreStr = Console.ReadLine();
            int nombre = Convert.ToInt32(nombreStr);
            string res;
            if (nombre%2 == 0)
            {
                res = "paire";
            }
            else
            {
                res = "impair";
            }
            Console.WriteLine("Le nombre rentré est {0} !", res);
        }
    }
}
