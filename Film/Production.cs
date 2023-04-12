using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFilm
{
    internal class Production
    {
        private string nom;
        public Production(string nom)
        {
            this.nom = nom;
        }

        public void Simuler()
        {
            Catalogue catalogue1 = new Catalogue();
            Film film1 = new Film("Titanic", "Paul", 2006, "Inspiré de faits réels");
            film1.AjouterGenre("Romance");
            film1.AjouterGenre("Drame");
            film1.AjouterActeur("Léonardo Dicaprio");
            film1.AjouterActeur("Kate Winslet");
            catalogue1.AjouterFilm(film1);
            Film film2 = new Film("La fille du Lac", "William", 2022, "Prix du film de l'année");
            film2.AjouterGenre("Drame");
            film2.AjouterGenre("Emotion");
            film2.AjouterActeur("Rose-Louise");
            film2.AjouterActeur("Emma-Kate");
            catalogue1.AjouterFilm(film2);
            Film film3 = new Film("Exorctiste", "Jean-Louis", 2008, "Deconseillé au moins de 15ans");
            film3.AjouterGenre("Fiction");
            film3.AjouterGenre("Violence");
            film3.AjouterActeur("Linda Blair");
            film3.AjouterActeur("Ellen Burstyn");
            catalogue1.AjouterFilm(film3);
            catalogue1.AfficherInfoCatalogue();

            catalogue1.RechercherParActeur("Léona");
            catalogue1.RechercherParActeur("Léonardo Dicaprio");
            catalogue1.RechercherParTitre("Tit");
            catalogue1.RechercherParTitre("Titanic");

        }

    }
}
