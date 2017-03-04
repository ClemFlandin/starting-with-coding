using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_21_Algorithmique_Exercice10_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = @"C:\Users\34011-36-06\Documents\Visual Studio 2015\Tutu.txt";
            string ligne;
            using (StreamReader sr = new StreamReader(@"C:\Users\34011-36-06\Documents\Visual Studio 2015\Tata.txt"))
            {
                while ((ligne = sr.ReadLine()) != null)
                {
                    File.AppendAllText(pathString, ligne + Environment.NewLine);
                }
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\34011-36-06\Documents\Visual Studio 2015\Toto.txt"))
            {
                while ((ligne = sr.ReadLine())!=null)
                {
                    File.AppendAllText(pathString, ligne + Environment.NewLine);
                }
            }
        }
    }
}
