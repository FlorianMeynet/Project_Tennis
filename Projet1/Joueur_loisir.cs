using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Joueur_loisir : Membre
    {
        private string cours;//Creer une classe cours

        public string Cours
        {
            get { return this.cours; }
        }

        public Joueur_loisir()
        {
            this.cours = "";
        }
        public Joueur_loisir(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe, string ville, bool paiement, string cours)
            : base(nom, prenom, naissance, adresse, telephone, sexe, ville, paiement)
        {
            this.cours = cours;
        }
    }
}
