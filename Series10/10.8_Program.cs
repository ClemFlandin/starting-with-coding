using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_21_Algorithmique_Exercice10_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\34011-36-06\Documents\Visual Studio 2015\test.txt";
            string[] lignes = File.ReadAllLines(path);
            File.Delete(path);
            for (int i = 0; i < 5; i++)
            {
                if(lignes[i].Contains('@') && !lignes[i].Contains("@@"))
                {
                    File.AppendAllText(path, lignes[i] + Environment.NewLine);
                }
                else if(lignes[i].Contains("@@") || !lignes[i].Contains('@'))
                {
                    File.AppendAllText(path, Environment.NewLine);
                }
            }
        }
    }
}
