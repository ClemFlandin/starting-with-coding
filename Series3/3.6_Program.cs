using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est ton âge mon petit?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            switch (age)
                {
                case 6:
                case 7:
                    Console.WriteLine("Tu es Poussin!");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Tu es Pupille!");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("Tu es Minime!");
                    break;
                default:
                    Console.WriteLine("Tu es cadet!");
                    break;

            }
        }
    }
}
