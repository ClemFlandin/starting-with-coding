using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notes = new int[9];
            for (int i = 0; i < notes.Length; i++)
            {
                string note = Console.ReadLine();
                notes[i] = Convert.ToInt32(note);
            }
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(notes[i]);
            }
        }
    }
}
