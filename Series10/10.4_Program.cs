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
            string[] lignes = { "Celui-ci", "Celui-la", "Eux", "Lui", "Moi" };
            string path = "C:\\Users\\clemf\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\2017_02_Algorithmique AFPA\\test.txt";
            File.WriteAllLines(@path, lignes);
            
            using (StreamWriter file = new StreamWriter (@path))
            {
                while (String.Compare(lignes[count], "Lolo") < 0)
                {
                    file.WriteLine(lignes[count]);
                    count++;
                }
                file.WriteLine("Lolo");
                for (int i = count; i < lignes.Length; i++)
                {
                    file.WriteLine(lignes[i]);
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
