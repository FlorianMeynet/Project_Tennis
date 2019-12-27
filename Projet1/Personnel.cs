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
    }
}
