using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_20_Algorithmique_Exercice10_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string sr;
            string path = "C:\\Users\\clemf\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\2017_02_Algorithmique AFPA\\test.txt";
            string[] noms = { "Celui-ci Dupond", "Celui-la Dupont", "Eux Jean", "Lui Martin", "Moi Roy" };


            Console.WriteLine("Quel est le nom de famille à modifier?");
            string aModifier = Console.ReadLine();

            Console.WriteLine("Quel sera son nouveau nom?");
            string newName = Console.ReadLine();
            string texte = File.ReadAllText(@path);
            using (StreamWriter file = new StreamWriter(@path))
            {
                
                foreach (string nom in noms)
                {
                    file.WriteLine(nom.Replace(aModifier, newName));
                    if (nom==nom.Replace(aModifier, newName))
                    {
                        count++;
                    }
                }
                if (count==noms.Length)
                {
                    Console.WriteLine("Le nom à modifier ne se trouve pas dans le carnet d'adresses!");
                }
            }
            using (StreamReader streamReader = new StreamReader(@path))
            {
                sr = streamReader.ReadToEnd();
            }
            Console.WriteLine(sr);
        }
    }
}
