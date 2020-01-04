using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Match_simple
    {
        private Joueur_competition joueur_a;
        private Joueur_competition joueur_b;
        private List<int> score;
        private string resultat;


        public Match_simple()
        {
            this.joueur_a=null;
            this.joueur_b=null;
            this.score=null;
            
        }
        public Match_simple(Joueur_competition a, Joueur_competition b)
        {
            this.joueur_a=a;
            this.joueur_b=b;
            this.score=null;
            this.resultat=null;
        }

        public Joueur_competition Joueur_a
        {
            get{return(this.joueur_a);}
            set{this.joueur_a=value;}
        }
        public Joueur_competition Joueur_b
        {
            get{return(this.joueur_b);}
            set{this.joueur_b=value;}
        }
        public List<int> Score
        {
            get{return(this.score);}
            set{this.score=value;}
        }
        public string Resultat
        {
            get{return(this.resultat);}
            set{this.resultat=value;}  
        }


        public void Comptage_score(int set_j_a, int set_j_b )
        {
            this.score[0]=(set_j_a);
            this.score[1]=(set_j_b);

        }
        public String Resultat_match()
        {
            if(this.Score[0]> this.Score[1]){return("Le joueur "+joueur_a.Nom+" a gagné");}
            else{return ("Le joueur " + joueur_b.Nom + " a gagné");}

        }




    }
}
