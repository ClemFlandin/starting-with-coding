using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_16_Algorithmique_Exercice10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string truc = "truc";
            var fileStream = new FileStream(@"U:\\34011-36-06\\Algorithmique_Exercices\\Algorithmique_Exercices_Serie10\\2017_02_16_Algorithmique_Exercice10_1\\test.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                truc = streamReader.ReadToEnd();
                
            }
            Console.WriteLine(truc);
        }
    }
}
