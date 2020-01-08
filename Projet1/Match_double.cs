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
        private List<int> score;
        private char resultat;
        public Match_double()
        {
            this.equipe_a = null;
            this.equipe_b = null;
            this.score = null;

        }
        public Match_double(Equipe_competition a, Equipe_competition b)
        {
            this.equipe_a = a;
            this.equipe_b = b;
            
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
        public List<int> Score
        {
            get { return (this.score); }
            set { this.score = value; }
        }
        public char Resultat
        {
            get { return (this.resultat); }
            set { this.resultat = value; }
        }

        public void Comptage_score(int set_j_a, int set_j_b)
        {
            this.score[0] = (set_j_a);
            this.score[1] = (set_j_b);

        }
        public String Score_match()
        {
            if (this.Score[0] > this.Score[1]) { return ("Le joueur " + equipe_a.Nom_team + " a gagné"); }
            else { return ("Le joueur " + equipe_b.Nom_team + " a gagné"); }

        }
        public bool Match_double_end()
        {
            if (this.score[0] == 2 || this.score[1] == 2) { return (true); } //On part du principe qu'un match se joue en 2 set gagnant
            else { return (false); }
        }

    }
}
