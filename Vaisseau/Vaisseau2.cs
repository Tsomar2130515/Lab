using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal partial class Vaisseau
    {
        public void ChangerVitesse(int newVitesse)
        {
            if (newVitesse > VitesseMaximale)
            {
                throw new Exception("La vitesse demandée dépasse la vitesse maximale du vaisseau");
            }
            else
            {
                VitesseMaximale = VitesseAcuelle;

            }

        }

        public void AfficherInfo()
        {
            Console.WriteLine($"*Nom Du Vaisseau :   {Nom}   :   Capacité   {Capacite}  Vitesse Actuelle  :   {VitesseAcuelle} Vitesse Maximale :    {VitesseMaximale}  : Statut  {Etat}   ");
            

        }

    }
}
