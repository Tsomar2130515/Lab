using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vaisseau;

class Program
{
    
    static void Main(string[] args)
    {
        Agence Ag = new Agence("Ag");
        Ag.Simuler();
        int  ch = 7;
        do
        {
            Console.WriteLine("Menu De Gestion Agence");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1- Améliorez les vaisseaux ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("2- Assigner un astronaute a un vaisseau ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("3- Ajouter un nouveau Vaisseau");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("4- Envoyer un Vaisseau Particulier en Mission");
            Console.WriteLine();
            int choix = Convert.ToInt32(Console.ReadLine());
            Ag.RealiserAction(choix);
            ch--;


        } while (ch !=0);

        Console.ReadKey();

    }
}
