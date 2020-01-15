using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Personnel : Identite
    {
        private string info_bancaire;
        private int salaire;
        private DateTime date_entree;

        public Personnel(string nom, string prenom, DateTime naissance, string adresse, long telephone, string info_bancaire, int salaire, DateTime date_entree)
            : base(nom, prenom, naissance, adresse, telephone)
        {
            this.info_bancaire = info_bancaire;
            this.salaire = salaire;
            this.date_entree = date_entree;
        }
        public Personnel()
        {
            this.info_bancaire = null;
            this.salaire = 0;
            this.date_entree = new DateTime();
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
