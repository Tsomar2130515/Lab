using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal  partial class Vaisseau
    {
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public int VitesseAcuelle{ get; set; }
        public int VitesseMaximale { get; set; }
        public string Etat { get; set; }
        public List<Mission> Missions;
        public List<string> PersonnelVaisseau;
        public Vaisseau(string nom, int capacite, int vitesseActuelle,int vitesseMaximale, string etat)
        {
            this.Nom = nom;
            this.Capacite = capacite;
            this.VitesseAcuelle = vitesseActuelle;
            this.VitesseMaximale = vitesseMaximale;
            this.Etat = etat;
            Missions = new List<Mission>();
            PersonnelVaisseau = new List<string>(); 


        }
        public void AjouterMission(Mission mission)
        {
            Missions.Add(mission);
        }
        public void AjouterPersonnel(string personne)
        {
            PersonnelVaisseau.Add(personne);
            
        }
        public void AfficherInfoPersonnel()
        {
            Console.WriteLine("Info Personnel du vaisseau " + Nom);
            foreach (string astronaute in PersonnelVaisseau)
            {
                Console.WriteLine(astronaute);  
            }

        }

        public void Decollage(int cord1,int cord2,string dateDepart,string nomMission,string dest,string dateArrivee,string statut)
        {
            if(Etat == "En orbite")
            {
                Console.WriteLine("Le vaisseau est déjà en orbite");
                //throw new Exception("Le vaisseau est déjà en orbite");
            }
           
            else
            {
                Etat = "En orbite";
                Mission mission = new Mission(nomMission, dest, dateDepart, dateArrivee, statut);
                mission.CompleterMission();
                Missions.Add(mission);
            }
           


        }

       
        public void Explorer( Planete laPlanete, int cord1, int cord2, string dateDepart, string nomMission, string dest, string dateArrivee, string statut)
        {
            if (PersonnelVaisseau.Count() < 1)
            {
                Console.WriteLine("Le vaisseau ne peut pas décoller car il n'a pas de personnel");

            }
            else if (PersonnelVaisseau.Count() >= 3)
            {
                Decollage(cord1, cord2, dateDepart, nomMission, dest, dateArrivee, statut);
                laPlanete.ExplorerOuPas();

            }
            else
            {
                Console.WriteLine("Le vaisseau  n'a pas le nombbre de personnel requis");

            }

        }
    }
}
