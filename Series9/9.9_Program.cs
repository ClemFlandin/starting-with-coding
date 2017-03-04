using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_Algortihmique_Exercice9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer la clé! ");
            string cle = Console.ReadLine();
            string temp = null;
            for (int i = 0; i < cle.Length; i++)
            {
                char debutAlphabet = Convert.ToChar(cle[i]);
                temp += NouvelAlphabet(debutAlphabet);
            }
            Console.WriteLine(temp);
            string alphabetCle = temp;
            Console.WriteLine("Veuillez rentrer le message! ");
            string message = Console.ReadLine();
            string tempBis = null;
            for (int i = 0; i < message.Length; i++)
            {
                int lettreChangee = message[i];
                if (lettreChangee > 90 || lettreChangee < 65)
                {
                    tempBis += Convert.ToChar(lettreChangee);
                }
                lettreChangee = alphabetCle[26 * (i % cle.Length) + lettreChangee - 65];
                tempBis += Convert.ToChar(lettreChangee);

            }
            message = tempBis;
            Console.WriteLine("Le message crypté est : {0}", message);
        }

        static string NouvelAlphabet(char lettreDepart)
        {
            string nouvelAlphabet = null;
            for (int i = 0; i < 26; i++)
            {
                int nouvelleLettre = lettreDepart + i;
                if (nouvelleLettre > 90)
                {
                    nouvelleLettre = Convert.ToChar(nouvelleLettre - 26);
                }
                else if (nouvelleLettre < 90 || nouvelleLettre > 65)
                {
                    nouvelleLettre = Convert.ToChar(nouvelleLettre);
                }
                nouvelAlphabet = nouvelAlphabet + Convert.ToChar(nouvelleLettre);
            }
            return nouvelAlphabet;
        }
    }
}
