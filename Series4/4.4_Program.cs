using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de photocopies avez-vous imprimé?");
            string nbreCopiesStr = Console.ReadLine();
            double nbreCopies = Convert.ToDouble(nbreCopiesStr);
            double prixTot = 0;
            if (nbreCopies <= 10)
                prixTot = nbreCopies * 0.10;
            if (nbreCopies > 10 && nbreCopies <= 30)
                prixTot = 1 + (nbreCopies - 10) * 0.09;
            if (nbreCopies > 30)
                prixTot = 2.8 + (nbreCopies - 30) * 0.08;
            Console.WriteLine("Vous nous devez : " + prixTot + "euros!");

        }
    }
}
