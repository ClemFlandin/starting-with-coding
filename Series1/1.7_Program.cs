using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 15, B = 18, C = 21, inter1 = B, inter2 = C;
            Console.WriteLine("A vaut {0}, B vaut {1} et C vaut {2}", A, B, C);
            B = A;
            C = inter1;
            A = inter2;
            Console.WriteLine("A vaut maintenant {0}, B vaut maintenant {1} et C vaut maintenant {2}", A, B, C);
        }
    }
}
