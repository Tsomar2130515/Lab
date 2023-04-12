using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFilm
{
    internal partial class Catalogue
    {

        public void RechercherParTitre(string titre)
        {
            int cpt = 0;
            foreach (Film leFilm in lesFilms)
            {
                if (leFilm.Nom == titre)
                {
                    Console.WriteLine("Informations du film recherché");
                    leFilm.AfficherInfo();
                    cpt = 1;

                }

            }
            if (cpt == 0)
            {
                Console.WriteLine("Le film que vous recerchez n'existe pas dans ce catalogue");

            }
        }
        public void RechercherParActeur(string acteur)
        {
            int cpt = 0;
            foreach (Film leFilm in lesFilms)
            {
                foreach (string unActeur in leFilm.lesActeurs)
                {
                    if (unActeur == acteur)
                    {
                        Console.WriteLine("Film dans lequel figure cet Acteur ou Actrice");
                        leFilm.AfficherInfo();
                        cpt = 1;

                    }


                }
            }
            if (cpt == 0)
            {
                Console.WriteLine("Le film que vous recerchez n'existe pas dans ce catalogue");

            }
        }

    }
}
