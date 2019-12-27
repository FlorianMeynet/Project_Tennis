using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    abstract class Identite
    {
        private string nom;
        private string prenom;
        private DateTime naissance;
        private string adresse;
        private long telephone;

        public string Nom
        {
            get { return this.nom; }
        }
        public string Prenom
        {
            get { return this.prenom; }
        }
        public DateTime Naissance
        {
            get { return this.naissance; }
        }
        public string Adresse
        {
            get { return this.adresse; }
        }
        public long Telephone
        {
            get { return this.telephone; }
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


    }
}
