using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_13_Algorithmique_Exercice7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 2, 4, 6, 10};
            int[] tab2 = { 1, 3, 5, 7, 9};
            int[] res = new int[tab1.Length + tab2.Length];
            for (int i = 0; i < res.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < tab1.Length; j++)
                {
                    for (int k = 0; k < tab2.Length; k++)
                    {
                        if (tab1[j] > tab2[k])
                        {
                            temp = tab2[k];
                        }
                        else
                        {
                            temp = tab1[j];
                        }
                    }
                }
                res[i] = temp;
                Console.WriteLine(res[i]);

            }

        }
        
    }
}
