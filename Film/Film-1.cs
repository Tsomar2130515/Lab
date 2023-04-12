using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFilm
{
    internal partial class Film
    {
        public string Nom { get; set; }
        public string Directeur { get; set; }
        public int Annee { get; set; }
        public List<string>lesActeurs;
        public Film(string nom,string directeur,int annee, string synopsis)
        {
            this.Nom = nom;
            this.Annee = annee;
            this.Directeur = directeur;
            this.Synopsis = synopsis;
            lesActeurs = new List<string>();
            genres=new List<string>();
        }

    }
}
