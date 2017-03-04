using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_20_Algorithmique_Exercice10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int compte = 0;
            string ligne;
            string path = "C:\\Users\\clemf\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\2017_02_Algorithmique AFPA\\test.txt";
            File.AppendAllText(@path, "David");
            using (StreamReader fichier = new StreamReader(@path))
            {
               while((ligne=fichier.ReadLine())!= null)
               {
                   Console.WriteLine(ligne);
                   compte++;
               }
            }                
        }

    }
}
