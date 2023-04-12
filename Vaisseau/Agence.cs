using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal class Agence
    {
        private string nom;
        private List<Mission> lesMissions;
        private List<Vaisseau> lesVaisseaux;
        private List<Planete>catalogueDePlanete;
        public Agence(string nom)
        {
            this.nom = nom;
            lesMissions = new List<Mission>();
            lesVaisseaux = new List<Vaisseau>();
            catalogueDePlanete = new List<Planete>();

        }

        public void AjouterMission(Mission mission)
        {
            lesMissions.Add(mission);
         }
        public void AjouterPlanete(Planete planete)
        {
            catalogueDePlanete.Add(planete);    
        }
        public void AjouterVaisseau(Vaisseau vaisseau)
        {
            lesVaisseaux.Add(vaisseau);
        }
        public void AfficherInfoVaisseaux()
        {
            foreach (Vaisseau vaisseau in lesVaisseaux)
            {
                vaisseau.AfficherInfo();
            }

        }
       


        public void Simuler()
        {
           
            Planete mars = new Planete("Mars", 15000, 2000, "Supportable", "Non-explorée");
            Planete neptune = new Planete("Neptune", 5000, 5000, "Supportable", "Explorée");
            Planete venus = new Planete("Venus", 7000, 2500, "Insupportable", "Non-explorée");
            Vaisseau vaisseau1 = new Vaisseau("LuneAx80", 10, 15, 20, "Pas en orbite");
            AjouterVaisseau(vaisseau1);
            vaisseau1.Explorer(mars, 5, 3, "12-07-2022", "Mission-Mars", "Mars", "12-08-2022", "En cours");
            foreach(Mission mission in vaisseau1.Missions)
            {
                lesMissions.Add(mission);
            }
            vaisseau1.AfficherInfo();


        }
        public void RechercherEtAjouter(string nom, string nomVaisseau)
        {
            int cpt = 0;

            foreach (Vaisseau vaisseau in lesVaisseaux)
            {
                if (vaisseau.Nom == nomVaisseau)
                {
                    vaisseau.AjouterPersonnel(nom);
                    cpt = 1;
                    Console.WriteLine("L'astronaute  " + nom + " a été ajouté avec succès au vaisseau " + nomVaisseau);
                    vaisseau.AfficherInfoPersonnel();


                }


            }

            if (cpt == 0)
            {
                Console.WriteLine("Le vaisseau que vous avez demandé n'existe pas ");

            }
        }

        public Planete TrouverPlaneteCorrespondante(string nom)
        {
            Planete plan = null;
            Planete mars = new Planete("Mars", 15000, 2000, "Supportable", "Non-explorée");
            Planete neptune= new Planete("Neptune", 5000, 5000, "Supportable", "Explorée");
            Planete venus = new Planete("Venus", 7000, 2500, "Insupportable", "Non-explorée");
            Planete uranus = new Planete("Uranus", 2000, 250, "Insupportable", "Non-explorée");
            Planete saturne = new Planete("Saturne", 3000, 25000, "Insupportable", "Non-explorée");
            catalogueDePlanete.Add(mars);
            catalogueDePlanete.Add(neptune);
            catalogueDePlanete.Add(venus);
            catalogueDePlanete.Add(uranus);
            catalogueDePlanete.Add(saturne);
            foreach (Planete planete in catalogueDePlanete)
            {
                if (planete.Nom==nom)
                {
                    plan = planete;
                   
                }

            }
            return plan;






        }

        public void RechercherEtExplorer(string nomPlanete, string nomVaisseau,string dateDep,string dateArr,string nomMiss)
        {
            int cpt = 0;
            Planete plan = TrouverPlaneteCorrespondante(nomPlanete);

            foreach (Vaisseau vaisseau in lesVaisseaux)
            {
                if (vaisseau.Nom == nomVaisseau)
                {
                    vaisseau.Explorer(plan,5,10,dateDep,nomMiss,plan.Nom,dateArr,"En cours");
                    cpt = 1;
                    Console.WriteLine("Le vaisseau " + nomVaisseau+ " a été envoyé en mission avec succès sur la planète  " + nomPlanete);
                    vaisseau.AfficherInfoPersonnel();
                    plan.ExplorerOuPas();


                }


            }

            if (cpt == 0)
            {
                Console.WriteLine("Le vaisseau ou la planète entré n'existe pas ");

            }
        }
        public void RealiserAction(int choix)
        {
            if(choix == 1)
            {
                int n = 5;
                foreach (Vaisseau vaisseau in lesVaisseaux)
                {
                    vaisseau.Capacite = vaisseau.Capacite + n;
                    vaisseau.VitesseAcuelle = vaisseau.VitesseAcuelle + n;
                    vaisseau.VitesseMaximale = vaisseau.VitesseMaximale + n;
                    vaisseau.Nom = vaisseau.Nom +"Amélioré";
                    vaisseau.AfficherInfo();
                    n++;
                }

            }
            else if(choix==2)
            {
                Console.WriteLine("Veuillez entre le nom de l'astronaute");
                string nom = Console.ReadLine();
                Console.WriteLine("Veuillez entre le nom du vaisseau auquel vous voulez l'attribuez");
                string nomVaisseau = Console.ReadLine();
                RechercherEtAjouter(nom, nomVaisseau);


            }
            else if(choix==3)
            {
                Console.WriteLine("Veuillez entrez les informations du nouveau vaisseau");
                Console.WriteLine("Nom ?");
                string nom = Console.ReadLine();
                Console.WriteLine("Capacite ?");
                int cap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("VitesseActuelle ?");
                int vit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("VitesseActuelle ?");
                int vitMax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Etat ? (En orbite ou Pas en orbite)");
                string etat = (Console.ReadLine());
                Vaisseau vaiss = new Vaisseau(nom,cap,vit,vitMax,etat);
                AjouterVaisseau(vaiss);
                vaiss.AfficherInfo();
            }
            else if (choix == 4)
            {
                Console.WriteLine("Nous avons un catalogue de 5 planètes: Saturne,Uranus,Mars,Neptune et Venus  : Laquelle choisissez-vous ?");
                string planete = Console.ReadLine();
                Console.WriteLine("Avec quelle vaisseau voulez-vous allez sur "+ planete+" ?");
                string vaisseau = Console.ReadLine();
                Console.WriteLine("date de départ ?");
                string dateDep = Console.ReadLine();
                Console.WriteLine("date d'arrivée prévue ?");
                string dateArr = Console.ReadLine();
                Console.WriteLine("Nom de la mission ?");
                string miss = Console.ReadLine();
                RechercherEtExplorer(planete, vaisseau, dateDep, dateArr, miss);
                
            }
            else 
            {
                Console.WriteLine("Veuillez entrez un chiffre valide");
            }




        }

    }

   


}

