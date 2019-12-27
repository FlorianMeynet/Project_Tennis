using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Match_double
    {
        private Equipe_competition equipe_a;
        private Equipe_competition equipe_b;
        private List<int[]> score;
        private char resultat;
        public Match_double()
        {
            this.equipe_a = null;
            this.equipe_b = null;
            this.score = null;

        }
        public Match_double(Equipe_competition a, Equipe_competition b, List<int[]> s, char r)
        {
            this.equipe_a = a;
            this.equipe_b = b;
            this.score = s;
            this.resultat = r;
        }

        public Equipe_competition Equipe_a
        {
            get { return (this.equipe_a); }
            set { this.equipe_a = value; }
        }
        public Equipe_competition Equipe_b
        {
            get { return (this.equipe_b); }
            set { this.equipe_b = value; }
        }
        public List<int[]> Score
        {
            get { return (this.score); }
            set { this.score = value; }
        }
        public char Resultat
        {
            get { return (this.resultat); }
            set { this.resultat = value; }
        }


    }
}
