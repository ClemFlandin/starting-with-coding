using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer trois noms! ");
            string[] noms = Console.ReadLine().Split();
            string nom1 = noms[0];
            string nom2 = noms[1];
            string nom3 = noms[2];
            string.Compare(nom1, nom2);
            if (String.Compare(nom1, nom2)<0 && String.Compare(nom2,nom3)<0)
                Console.WriteLine("Vos noms sont classés par ordre alphabétique! ");
            else
                Console.WriteLine("Vos nmos ne sont pas par ordre alphabétique! ");
        }
        
    }
}
