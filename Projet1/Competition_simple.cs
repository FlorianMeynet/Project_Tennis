using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Competition_simple
    {
        private int nb_match;
        private List<char> resultat_match;
        private List<char[]> liste_match_simple;

        public Competition_simple()
        {
            this.liste_match_simple = null;
            this.nb_match = 0;
            this.resultat_match = null;
        }

        public Competition_simple(int n)
        {
            this.nb_match = n;
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
        public List<char[]> Liste_match_simple
        {
            get { return (this.liste_match_simple); }
            set { this.liste_match_simple = value; }
        }

        public void Creation_List_Match()
        {
           
        }

    }
}
