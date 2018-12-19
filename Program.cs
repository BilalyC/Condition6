using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veillez renseigner un mois (la première lettre en majuscule) :");
            string month = Console.ReadLine();
            switch (month)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("La saison du mois saisi est l'ETE.");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                default:
                    Console.WriteLine("Soit la première lettre du mois est en minuscule, soit il y a une erreur dans la saisie.");
                    break;
            }
        }
    }
}
