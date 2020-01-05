using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Competition_equipe : Competition
    {
        private int nb_match_simple;
        private int nb_match_double;
        private List<char> resultat_match;
        private List<Match_simple> liste_match_simple;
        private List<Match_double> liste_match_double;
        public Competition_equipe()
        {
            this.liste_match_simple = null;
            this.liste_match_double = null;
            this.nb_match_double = 0;
            this.nb_match_simple = 0;
            this.resultat_match = null;
        }

        public Competition_equipe(int ns,int nd, List<Match_simple> l_s,List<Match_double> l_d, List<char> r,string l, List<Joueur_competition[]> l_e, int[] c, int nb_j, string n, double niv, int nb_j_m) : base(l, l_e, c, nb_j, n, niv, nb_j_m)
        {
            this.nb_match_simple = ns;
            this.nb_match_double = nd;
            this.resultat_match = r;
            this.liste_match_simple = l_s;
            this.liste_match_double = l_d;
        }
        public int Nb_match_simple
        {
            get { return (this.nb_match_simple); }
            set { this.nb_match_simple = value; }
        }
        public int Nb_match_double
        {
            get { return (this.nb_match_double); }
            set { this.nb_match_double = value; }
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
        public List<Match_double> Liste_match_double
        {
            get { return (this.liste_match_double); }
            set { this.liste_match_double = value; }
        }

        public bool Assez_de_joueur()
        {
            return (this.Nb_joueur >= this.Nb_j_min);
        }

        public bool Tous_match_joueur()
        {
            foreach (Match_simple match_s in this.liste_match_simple)
            {
                if (match_s.Match_simple_end() == false)
                {
                    return (false);
                }
            }
            foreach(Match_double match_d in this.liste_match_double)
            {
                if (match_d.Match_double_end() == false)
                {
                    return (false);
                }
            }
            return (true);
        }


    }
}
