using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Personnel : Identite
    {
        protected bool sexe;
        private string ville;
        protected string info_bancaire;
        protected int salaire;
        protected DateTime date_entree;
        protected bool est_entraineur_joueur;

        public Personnel(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe,string ville, string info_bancaire, int salaire, DateTime date_entree)
            : base(nom, prenom, naissance, adresse, telephone)
        {
            this.sexe = sexe;
            this.ville = ville;
            this.info_bancaire = info_bancaire;
            this.salaire = salaire;
            this.date_entree = date_entree;
            this.est_entraineur_joueur = false;
        }
        public Personnel()
        {
            this.info_bancaire = null;
            this.ville = "";
            this.salaire = 0;
            this.date_entree = new DateTime();
            this.est_entraineur_joueur = false;
            this.sexe = false;
        }

        public Personnel(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe, string ville, string info_bancaire, int salaire, DateTime date_entree,bool est_entraineur_joueur)
            : base(nom, prenom, naissance, adresse, telephone)
        {
            this.ville = ville;
            this.info_bancaire = info_bancaire;
            this.salaire = salaire;
            this.date_entree = date_entree;
            this.est_entraineur_joueur = est_entraineur_joueur;
            this.sexe = sexe;
        }

        public bool Est_entraineur_joueur
        {
            get { return this.est_entraineur_joueur; }
            set { this.est_entraineur_joueur = value; }
        }
        public string Ville
        {
            get { return this.ville;}
            set { this.ville = value; }
        }
        public bool Sexe 
        {
            get { return this.sexe;}
            set { this.sexe = value; }
        }
        public string Info_bancaire
        {
            get{ return this.info_bancaire; }
            set { this.info_bancaire = value; }
        }
        public int Salaire
        {
            get { return this.salaire; }
            set { this.salaire = value; }
        }
        public DateTime Date_entree
        {
            get { return this.date_entree; }
            set { this.date_entree = value; }
        }

        public override string ToString()
        {
            return (base.ToString()+ "        "+this.info_bancaire + "        " + this.salaire+ "        " + this.date_entree.Day+"/"+this.date_entree.Month+"/"+this.date_entree.Year);
        }
    }
}
