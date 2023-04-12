using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFilm
{
    internal partial class Catalogue
    {
        private List<Film>lesFilms;
        public Catalogue()
        {
            lesFilms = new List<Film>();
        }

        public void AjouterFilm(Film film)
        {
            lesFilms.Add(film);
        }
        public void SupprimerFilm(Film film)
        {
            lesFilms.Remove(film);
        }
        public void AfficherInfoCatalogue()
        {
            Console.WriteLine("Informations Du Catalogue");
            foreach (Film unFilm in lesFilms)
            {
                unFilm.AfficherInfo();

            }

        }



    }
}
