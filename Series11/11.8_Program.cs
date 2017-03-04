using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_19_Algorithmique_Exercice11_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez la première valeur! ");
            string val1Str = Console.ReadLine();
            int val1 = Convert.ToInt32(val1Str);
            Console.WriteLine("Rentrez la deuxième valeur! ");
            string val2Str = Console.ReadLine();
            int val2 = Convert.ToInt32(val2Str);
            int[] res = new int[2];
            res = InversionValeurs(val1, val2);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
        }
        static int[] InversionValeurs(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
            int[] res = new int[2];
            res[0] = a;
            res[1] = b;
            return (res);
        }
    }
}
