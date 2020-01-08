﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Competition_simple : Competition
    {
        Random rnd = new Random();
        private int nb_match;
        private List<char> resultat_match;
        private List<Match_simple> liste_match_simple;

        public Competition_simple()
        {
            this.liste_match_simple = null;
            this.nb_match = 0;
            this.resultat_match = null;
        }

        public Competition_simple(int nb_match, string l, List<Joueur_competition[]> l_e, int[] c, int nb_j, string n, int niv, int nb_j_m): base(l,l_e,c,nb_j,n,niv,nb_j_m)
        {
            this.nb_match = nb_match;
            this.resultat_match = null;
            this.liste_match_simple = null;
        }
        public int Nb_match
        {
            get { return (this.nb_match); }
            set { this.nb_match = value; }
        }
        public List<char> Resultat_match
        {
            get { return (this.resultat_match); }
            set { this.resultat_match = value; }
        }
        public List<Match_simple> Liste_match_simple
        {
            get { return (this.liste_match_simple); }
            set { this.liste_match_simple = value; }
        }

        public void Creation_List_Match(Equipe_competition equipe_b)
        {
            if (Assez_de_joueur() == true and equipe_b.Assez_de_joueur()==true)
            {
                for(int n = 0; n< nb_match; n++)
                {
                    
                }
            }
        }


        public bool Assez_de_joueur()
        {
            return (this.Nb_joueur >= this.Nb_j_min);
        }

        public bool Compet_end()
        {
            foreach(Match_simple match in this.liste_match_simple)
            {
                if (match.Match_simple_end() == false)
                {
                    return (false);
                }
            }
            return (true);
        }
    }
}
