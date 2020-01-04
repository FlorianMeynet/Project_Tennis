using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Membre : Identite
    {
        private bool sexe; //renvoie true si c'est une femme
        private string ville;
        private bool paiement;

        public Membre()
        {
            this.sexe = true;
            this.ville = "";
            this.paiement = false;
        }
        public Membre(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe, string ville, bool paiement) : base(nom, prenom, naissance, adresse, telephone)
        {
            this.sexe = sexe;
            this.ville = ville;
            this.paiement = paiement;
        }

        public bool adulte()
        {
            bool rep = false;
            if (this.Age() > 18)
            {
                rep = true;
            }
            return rep;
        }
        public int prix(string villeclub, bool competition)
        {
            int rep = 0;
            if (this.ville == villeclub)
            {
                if (this.adulte())
                {
                    rep = 200;
                }
                else
                {
                    rep = 130;
                }
            }
            else
            {
                if (this.adulte())
                {
                    rep = 280;
                }
                else
                {
                    rep = 180;
                }
            }
            if (competition)
            {
                rep += 20;
            }
            return rep;
        }
    }
}
