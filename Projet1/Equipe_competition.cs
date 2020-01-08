using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Equipe_competition
    {
        private DateTime date_compet;
        private int point_equipe;
        private List<Joueur_competition> list_joueur_equipe;
        private List<Joueur_competition> list_joueur_equipe_ok=null;
// private List<Joueur_competition> list_deja_jouer;
        private string nom_team;
        public Equipe_competition(DateTime date)
        {
            this.date_compet=date;

        }
        public List<Joueur_competition> List_joueur_equipe
        {
            get{return this.list_joueur_equipe;}
            set {this.list_joueur_equipe=value;}

        }
        public int Point_equipe
        {
            get{return this.point_equipe;}
            set {this.point_equipe=value;}
        }
        public string Nom_team
        {
            get { return this.nom_team; }
            set { this.nom_team = value; }
        }

        

        public void Ajout_joueur(Joueur_competition a)
        {
            foreach(Joueur_competition joueur in this.list_joueur_equipe)
            {
                foreach (DateTime date_a_verifier in joueur.Date_compet)
                {
                    if (date_a_verifier != this.date_compet)
                    {
                        this.list_joueur_equipe_ok.Add(joueur);
                        joueur.Date_compet.Add(date_compet);
                    }
                }
            }

            
        }

        /*public void Ajout_deja_joueur(Joueur_competition b)
        {
            list_deja_jouer.Add(b);
        }
        
         public List<Joueur_competition> List_deja_jouer
        {
            get { return this.list_deja_jouer; }
            set { this.list_deja_jouer = value; }
        }*/

    }
}
