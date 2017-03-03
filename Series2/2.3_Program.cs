using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer le prix de votre article : ");
            string prixArticleString = Console.ReadLine();
            double prixArticle = Convert.ToDouble(prixArticleString);

            Console.WriteLine("Veuillez rentrer le nombre d'articles : ");
            string nombreArticlesString = Console.ReadLine();
            double nombreArticles = Convert.ToDouble(nombreArticlesString);

            Console.WriteLine("Veuillez rentrer le taux de TVA : ");
            string tauxTVAString = Console.ReadLine();
            double tauxTVA = Convert.ToDouble(tauxTVAString);

            double prixTotal = (prixArticle + prixArticle * tauxTVA) * nombreArticles;
            Console.WriteLine("Le prix total TTC est de : " + prixTotal);
        }
    }
}
