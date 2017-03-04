using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_21_Algorithmique_Exercice10_9
{
    //class Vendeur
    //{
    //    public string Name { get; set; }
    //    public int SaleValue { get; set; }
    //    public Vendeur(string name, int saleValue)
    //    {
    //        Name = name;
    //        SaleValue = saleValue;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int found=0, i=0;
            int count = 0;
            string path = @"C:\Users\34011-36-06\Documents\Visual Studio 2015\Projects\test.txt";
            string[] text = File.ReadAllLines(path);
            int[] sales = new int[text.Length];
            string[] salesMen = new string[text.Length];
            while(String.Compare(text[i], text[i+1])==0)
            {

            }
            //foreach (string info in text)
            //{
            //    Console.WriteLine(info);
            //}
            //int ventes = 0;
            //for (int i = 0; i < text.Length-1; i++)
            //{
            //    found = text[i].IndexOf(": ");
            //    while (String.Compare(text[i], text[i + 1]) == 0)
            //    {
            //        ventes += Convert.ToInt32(text[i].Substring(found + 2));
            //    }
            //    sales[count] = ventes;
            //    count++;
            //    ventes = 0;
            //}
            //for (int j = 0; j < sales.Length; j++)
            //{
            //    Console.WriteLine(sales[j]);
            //}
            //int positionFinLigne = text.IndexOf('\n');
            //Console.WriteLine((int)lignes[1]);
        }
    }
}
