using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Club
    {
        private string nom;
        private string ville;
        private List<Membre> liste_membre;


        public Club( string n,string v,List<Membre> l)
        {
            this.nom=n;
            this.ville=v;
            this.liste_membre=l;
        }
        public Club()
        {
            this.nom="";
            this.ville="";
            this.liste_membre=null;
        }

        public string Nom
        {
             get { return (this.nom); }
            set { this.nom = value; }
        }
        public string Ville
        {
             get { return (this.ville ); }
            set { this.ville = value; }
        }
        public List<Membre> Liste_membre
        {
             get { return (this.liste_membre ); }
            set { this.liste_membre = value; }
        }

        public int[] ResultatClub()
        {
            int nbre_match = 0;
            int nbre_victoire = 0;
            foreach(Membre m in this.liste_membre)
            {

            }
            int[] tab = { nbre_match, nbre_victoire };
            return (tab);
        }


            
    }
}
