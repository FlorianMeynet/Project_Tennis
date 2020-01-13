using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Competition
    {
        private string lieu;
        private List<Joueur_competition> liste_equipe;
        List<Joueur_competition> liste_joueur_ok = null;
        private int[] cat_age;
        private int nb_jours;
        private string nom;
        private double classement_max;
        private int nb_j_min;
        int nb_match_total=0;
        int annee_min;
        int annee_max;


        public Competition()
        {
            this.lieu = "";
            this.liste_equipe = null;
            this.cat_age = null;
            this.nb_jours = 0;
            this.nom = "";
            this.classement_max = 0;
            this.nb_j_min = 0;
            this.annee_min = 0;
            this.annee_max = 0;


        }
        public Competition(string l, List<Joueur_competition> l_e, int[] c, int nb_j, string n, double niv, int nb_j_m,int annee_min,int annee_max)
        {
            this.lieu = l;
            this.liste_equipe = l_e;
            this.cat_age = c;
            this.nb_jours = nb_j;
            this.nom = n;
            this.classement_max = niv;
            this.nb_j_min = nb_j_m;
            this.annee_max = annee_max;
            this.annee_min = annee_min;

        }
        public int Annee_min
        {
            get { return this.annee_min; }
            set { this.annee_min = value; }
        }
        public int Annee_max
        {
            get { return this.annee_max; }
            set { this.annee_max = value; }
        }
        public int Nb_match_total
        {
            get { return (this.nb_match_total); }
            set { this.nb_match_total = value; }
        }
        public string Lieu
        {
            get { return (this.lieu); }
            set { this.lieu = value; }
        }
        public List<Joueur_competition> Liste_equipe
        {
            get { return (this.liste_equipe); }
            set { this.liste_equipe = value; }
        }

        
        public List<Joueur_competition> Liste_joueur_ok
        {
            get { return (this.liste_joueur_ok); }
            set { this.liste_joueur_ok = value; }
        }
        public int[] Cat_age
        {
            get { return (this.cat_age); }
            set { this.cat_age = value; }
        }
        public int Nb_jours
        {
            get { return (this.nb_jours); }
            set { this.nb_jours = value; }
        }
        public string Nom
        {
            get { return (this.nom); }
            set { this.nom = value; }
        }
        public double Classement_max
        {
            get { return (this.classement_max); }
            set { this.classement_max = value; }
        }
        public int Nb_j_min
        {
            get { return (this.nb_j_min); }
            set { this.nb_j_min = value; }
        }

        public void Compatibilite_age()
        {
            foreach (Joueur_competition joueur in liste_equipe)
            {
                liste_joueur_ok = null;
                
                    if (joueur.Age <= cat_age[0] || joueur.Age <= cat_age[1])
                    {
                        liste_joueur_ok.Add(joueur);
                    }
            }
        }

        public int Nb_joueur
        {
            get
            {
                int conteur = 0;

                foreach (Joueur_competition list_joueur in liste_joueur_ok)
                {

                    conteur ++;
                }
                return (conteur);
            }



        }
    }
}
