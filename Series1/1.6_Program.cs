using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 6, B = 8, inter;
            inter = A;
            A = B;
            B = inter;
            Console.WriteLine("A vaut : {0} et B vaut {1}", A, B);
        }
    }
}
