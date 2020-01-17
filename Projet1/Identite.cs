using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    abstract class Identite
    {
        protected string nom;
        protected string prenom;
        protected DateTime naissance;
        protected string adresse;
        protected long telephone;

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public DateTime Naissance
        {
            get { return this.naissance; }
            set { this.naissance = value; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }
        public long Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public Identite()
        {
            this.nom = "";
            this.prenom = "";
            this.naissance =new DateTime();
            this.adresse = "";
            this.telephone = -1;
        }
        public Identite(string nom, string prenom, DateTime naissance, string adresse, long telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.naissance = naissance;
            this.adresse = adresse;
            this.telephone = telephone;
        }

        public int Age()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - this.naissance.Year;
            if (naissance > now.AddYears(-age))
                age--;
            return age;
        }
        public override string ToString()
        {
            return (this.nom + "          "+ this.prenom+ "          " + this.naissance.Day+"/"+ this.naissance.Month + "/" + this.naissance.Year + "          " + this.adresse+ "          " +"0"+this.telephone);
        }


    }
}
