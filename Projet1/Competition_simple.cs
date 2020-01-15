using System;
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

        public Competition_simple(int nb_match, string l, List<Joueur_competition> l_e, int[] c, int nb_j, string n, int niv, int nb_j_m,int annee_min,int annee_max): base(l,l_e,c,nb_j,n,niv,nb_j_m,annee_min,annee_max)
        {
            this.nb_match = nb_match;
            this.resultat_match = null;
            this.liste_match_simple = null;
            this.Nb_match_total += this.nb_match;
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
            Random generateur = new Random();
            if (Assez_de_joueur() == true )
            {
                for(int n = 0; n< nb_match; n++)
                {
                    int nb = generateur.Next(1, equipe_b.List_joueur_equipe.Count());
                    int na = generateur.Next(1, this.Liste_joueur_ok.Count());
                    Match_simple ma = new Match_simple(equipe_b.Liste_joueur_ok[nb], this.Liste_joueur_ok[na]);
                    Liste_match_simple.Add(ma);
                }
            }
            foreach(Match_simple m in Liste_match_simple)
            {
                int res = generateur.Next(0, 1);
                if (res == 1)
                {
                    m.Joueur_a.Nb_match_jouer++;
                    m.Joueur_b.Nb_match_jouer++;
                    m.Joueur_a.Nb_match_gagner++;
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
