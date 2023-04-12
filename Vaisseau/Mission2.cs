using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaisseau
{
    internal partial class Mission
    {
        public void CompleterMission()
        {
            Statut = "Terminée";
            Console.WriteLine("La mission  "+Nom +"  vient de se terminer  Date De Départ "+ DateDepart+" Date D'ARRIVÉE  "+DateArriveePrevue+"  DESTINATION  "+Destination+"  Statut De la Mission  " + Statut);



        }
    }
}
