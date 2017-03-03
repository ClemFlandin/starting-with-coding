using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer l'heure!");
            string[] heureStr = Console.ReadLine().Split();
            string heuresStr = heureStr[0];
            string minutesStr = heureStr[1];
            string secondesStr = heureStr[2];
            int heures = Convert.ToInt32(heuresStr);
            int minutes = Convert.ToInt32(minutesStr);
            int secondes = Convert.ToInt32(secondesStr);
            secondes++;
            if (secondes == 60)
                {
                    minutes++;
                    secondes -= 60;
                }
            if (minutes == 60)
            {
                heures++;
                minutes -= 60;
            }
            if (heures == 24)
                heures -= 24;
            Console.WriteLine("Dans une seconde il sera " + heures + "heures et " + minutes + "minutes" + secondes + "secondes!");
        }
    }
}
