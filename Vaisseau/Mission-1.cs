using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal partial class Mission
    {
        public string Nom { get; set; }
        public string Destination { get; set; }
        public string DateDepart { get; set; }
        public string DateArriveePrevue { get; set; }
        public string Statut { get; set; }
        public Mission(string nom,string destination,string dateDepart,string dateArrivee,string statut)
        {
            this.Nom = nom;
            this.DateArriveePrevue = dateArrivee;
            this.DateDepart = dateDepart;
            this.Statut = statut;
            this.Destination = destination;
        }
       

    }


}
