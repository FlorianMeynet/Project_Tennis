using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Joueur_competition : Membre
    {
        private double classement;
        private int age;
        private int point_joueur;
        private int nb__match_jouer;
        private int nb__match_gagner;
        private List<DateTime> date_compet;


        public Joueur_competition(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe, string ville, bool paiement) : base(nom, prenom, naissance, adresse, telephone, sexe, ville, paiement)
        {
            this.classement = 0;
            this.age = 0;
            this.point_joueur = 0;
            this.nb__match_gagner = 0;
            this.nb__match_jouer = 0;

        }
        public Joueur_competition(string nom, string prenom, DateTime naissance, string adresse, long telephone, bool sexe, string ville, bool paiement, int c, int a, int p, int nb_j, int nb_g) : base(nom, prenom, naissance, adresse, telephone, sexe, ville, paiement)
        {
            this.classement = c;
            this.age = a;
            this.point_joueur = p;
            this.nb__match_gagner = nb_g;
            this.nb__match_jouer = nb_j;

        }

        public double Classement
        {
            get { return (this.classement); }
            set { this.classement = value; }
        }
        public new int Age
        {
            get { return (this.age); }
            set { this.age = value; }
        }

        public List<DateTime> Date_compet
        {
            get { return this.date_compet; }
            set { this.date_compet = value; }
        }
        public int Point_joueur
        {
            get { return (this.point_joueur); }
            set { this.point_joueur = value; }
        }
        public int Nb_match_jouer
        {
            get { return (this.nb__match_jouer); }
            set { this.nb__match_jouer = value; }
        }
        public int Nb_match_gagner
        {
            get { return (this.nb__match_gagner); }
            set { this.nb__match_gagner = value; }
        }

    }
}