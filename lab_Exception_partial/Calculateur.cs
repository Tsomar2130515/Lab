using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCalculateur
{
    internal class Calculateur
    {
        private string nom;
        public Calculateur(string nom)
        {
            this.nom = nom;
        }
        public  int Diviser(int n1,int n2)
        {
           int  resultat = 0;
           resultat = n1 / n2;
            return resultat;
            
        }
        public int Multiplier(int n1, int n2)
        {
            int resultat = 0;
            resultat = n1*n2;
            return resultat;

        }

    }
}
