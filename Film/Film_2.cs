using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFilm
{
    internal partial class Film
    {
        private string Synopsis { get; set; }
        private List<string>genres;
        public void AjouterGenre(string genre)
        {
            genres.Add(genre);
        }
        public void AjouterActeur(string acteur)
        {
            lesActeurs.Add(acteur);
        }
        public void AfficherInfo()
        {
            Console.WriteLine($"*Nom Du Film :   { Nom}   Directeur :   {Directeur}  Année De Sortie:   {Annee}    ");
            Console.WriteLine("Genres Du Film");
            foreach (string genre in genres)
            {
                Console.WriteLine();
                Console.WriteLine(" - " + genre);
                Console.WriteLine();

            }
            Console.WriteLine("Casting");
            foreach (string acteur in lesActeurs)
            {
                Console.WriteLine();
                Console.WriteLine(" - " + acteur);
                Console.WriteLine();

            }

        }
        

    }
}
