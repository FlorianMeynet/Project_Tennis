using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Membre : Identite , IComparable
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
        public bool Sexe
        {
            get { return this.sexe; }
            set { this.sexe = value; }
        }
        public string Ville
        {
            get { return this.ville; }
            set { this.ville = value; }
        }
        public bool Paiement
        {
            get { return this.paiement; }
            set { this.paiement = value; }
        }

        public override string ToString()
        {
            return (base.ToString() + "\n Sexe : " + this.sexe + "\n Ville : " + this.ville + "\n Paiement : " + this.paiement);
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

        public int Compareto(Object val)
        {
            Membre valA = (Membre)val;
            return (this.Nom.CompareTo(valA.Nom));
        }

        public int CompareP(Membre b, Membre c)
        {
            return (b.Prenom.CompareTo(b.Prenom));
        }

        public static int CompareD(Membre b, Membre c)
        {
            return (b.Naissance.CompareTo(c.Naissance));
        }
        public static int CompareS(Membre b, Membre c)
        {
            return (b.Sexe.CompareTo(c.Sexe));
        }
        public static int CompareV(Membre b, Membre c)
        {
            return (b.Ville.CompareTo(c.Ville));
        }
        public static int ComparePA(Membre b, Membre c)
        {
            return (b.Paiement.CompareTo(c.Paiement));
        }
    }
}
