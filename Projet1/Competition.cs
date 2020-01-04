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
        private List<Joueur_competition[]> liste_equipe;
        List<List<Joueur_competition>> liste_equipe_ok = null;
        List<Joueur_competition> liste_joueur_ok = null;
        private int[] cat_age;
        private int nb_jours;
        private string nom;
        private int niveau;
        private int nb_j_min;

        public Competition()
        {
            this.lieu = "";
            this.liste_equipe = null;
            this.cat_age = null;
            this.nb_jours = 0;
            this.nom = "";
            this.niveau = 0;
            this.nb_j_min = 0;

        }
        public Competition(string l, List<Joueur_competition[]> l_e, int[] c, int nb_j, string n, int niv, int nb_j_m)
        {
            this.lieu = l;
            this.liste_equipe = l_e;
            this.cat_age = c;
            this.nb_jours = nb_j;
            this.nom = n;
            this.niveau = niv;
            this.nb_j_min = nb_j_m;

        }
        public string Lieu
        {
            get { return (this.lieu); }
            set { this.lieu = value; }
        }
        public List<Joueur_competition[]> Liste_equipe
        {
            get { return (this.liste_equipe); }
            set { this.liste_equipe = value; }
        }

        public List<List<Joueur_competition>> Liste_equipe_ok
        {
            get { return (this.liste_equipe_ok); }
            set { this.liste_equipe_ok = value; }
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
        public int Niveau
        {
            get { return (this.niveau); }
            set { this.niveau = value; }
        }
        public int Nb_j_min
        {
            get { return (this.nb_j_min); }
            set { this.nb_j_min = value; }
        }

        public void Compatibilite_age()
        {
            foreach (Joueur_competition[] list_joueur in liste_equipe)
            {
                liste_joueur_ok = null;
                foreach (Joueur_competition joueur in list_joueur)
                {
                    if (joueur.Age <= cat_age[0] || joueur.Age <= cat_age[1])
                    {
                        liste_joueur_ok.Add(joueur);
                    }


                }
                liste_equipe_ok.Add(liste_joueur_ok);
            }
        }

        public int Nb_joueur
        {
            get
            {
                int conteur = 0;

                foreach (List<Joueur_competition> list_joueur in liste_equipe_ok)
                {

                    conteur += list_joueur.Count;
                }
                return (conteur);
            }



        }
    }
}
