using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Competition_equipe
    {
        private int nb_match_simple;
        private int nb_match_double;
        private List<char> resultat_match;
        private List<char[]> liste_match_simple;

        public Competition_equipe()
        {
            this.liste_match_simple = null;
            this.nb_match_double = 0;
            this.nb_match_simple = 0;
            this.resultat_match = null;
        }

        public Competition_equipe(int ns,int nd, List<char[]> l, List<char> r)
        {
            this.nb_match_simple = ns;
            this.nb_match_double = nd;
            this.resultat_match = r;
            this.liste_match_simple = l;
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
        public List<char[]> Liste_match_simple
        {
            get { return (this.liste_match_simple); }
            set { this.liste_match_simple = value; }
        }
    }
}
