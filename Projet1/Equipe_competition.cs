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
        private List<Joueur_competition> list_deja_jouer;

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

        public List<Joueur_competition> List_deja_jouer
        {
            get { return this.list_deja_jouer; }
            set { this.list_deja_jouer = value; }
        }

        public void Ajout_joueur(Joueur_competition a)
        {
            //on ne peut pas savoir si le joueur a dautre compet
            qdzdqlist_joueur_equipe.Add(a);
        }

        public void Ajout_deja_joueur(Joueur_competition b)
        {
            list_deja_jouer.Add(b);
        }

    }
}
