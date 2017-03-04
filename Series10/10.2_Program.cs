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
            string fileContent="Hello/world!";
            string path = "C:\\Users\\34011-36-06\\Documents\\Visual Studio 2015\\test.txt";
            File.WriteAllText(@path, "Salut/tout/le/monde/!");
            using (StreamReader streamReader = new StreamReader(@path))
            {
                fileContent = streamReader.ReadToEnd();
            }
            
            using (StreamReader sr = new StreamReader(@path))
            {
                foreach (var item in fileContent)
                {
                    if (item == '/')
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(item);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
