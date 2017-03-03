using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Algorithmique_Exercice4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer l'heure!");
            string[] heureStr = Console.ReadLine().Split();
            string heuresStr = heureStr[0];
            string minutesStr = heureStr[1];
            int heures = Convert.ToInt32(heuresStr);
            int minutes = Convert.ToInt32(minutesStr);
            if (minutes != 59)
                {
                    minutes++;
                    Console.WriteLine("Dans une minute il sera " + heures + "heures et " + minutes + "minutes");
                }
            else
                {
                    minutes = 0;
                    if(heures!=23)
                        {
                            heures++;
                            Console.WriteLine("Dans une minute il sera " + heures + "heures et " + minutes + "minutes");
                        }
                    else
                        {
                            heures = 0;
                            Console.WriteLine("Dans une minute il sera " + heures + "heures et " + minutes + "minutes");
                        }
                }
        }
    }
}
