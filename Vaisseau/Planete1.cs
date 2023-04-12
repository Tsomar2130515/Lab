using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal class Planete
    {
        public string Nom { get; set; }
        public int  Taille { get; set; }
        public int DistanceTerre { get; set; }
        public string EtatAtmosphere{ get; set; }
        public string Explore{ get; set; }
        public Planete(string nom,int taille, int distanceTerre, string etatAtmosphere, string explore)
        {
            this.Nom = nom;
            this.Taille = taille;
            this.DistanceTerre = distanceTerre;
            this.EtatAtmosphere = etatAtmosphere;
            this.Explore = explore;

        }
        public void ExplorerOuPas()
        {
            if (Explore == "Exploré")
            {
                throw new Exception("Cette planète a déjà été explorée");
            }
            else
            {
                Explore = "Exploré";
                Console.WriteLine("L'exploration de la Planète  " + Nom + "  vient de se terminer  Taille  " + Taille+ " Distance  " + DistanceTerre+ "  " + " Etat Atmosphère " + EtatAtmosphere+ "  Statut "+Explore);

            }

        }
        public void AfficherInfo()
        {
            Console.WriteLine($"*Nom De la Planete :   {Nom}   :   Taille   {Taille} Distance-Terre  :   {DistanceTerre}  Etat Atmosphère :    {EtatAtmosphere}  : Statut  {Explore}   ");


        }



    }
}
