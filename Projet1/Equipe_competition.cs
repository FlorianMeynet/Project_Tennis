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

        public void ajout_joueur(Joueur_competition a)
        {
             //on ne peut pas savoir si le joueur a dautre compet

        }
    }
}
