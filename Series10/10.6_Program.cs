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

            string sr;
            string path = "C:\\Users\\clemf\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\2017_02_Algorithmique AFPA\\test.txt";
            string[] noms = { "Dupond Celui-ci", "Martin Celui-la ", "Jean Eux", "Roy Lui", "Dupont Moi" };

            string texte = File.ReadAllText(@path);
            using (StreamWriter file = new StreamWriter(@path))
            {
                Array.Sort(noms);
                foreach (var nom in noms)
                {
                    file.WriteLine(nom);
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
