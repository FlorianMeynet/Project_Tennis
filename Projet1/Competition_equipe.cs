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

        public Competition_equipe(int ns,int nd, List<Match_simple> l_s,List<Match_double> l_d, List<char> r,string l, List<Joueur_competition> l_e, int nb_j, string n, int niv, int nb_j_m,int annee_min, int annee_max,DateTime date_debut) : base(l, l_e,nb_j, n, niv, nb_j_m, annee_min, annee_max, date_debut)
        {
            this.nb_match_simple = ns;
            this.nb_match_double = nd;
            this.resultat_match = r;
            this.liste_match_simple = l_s;
            this.liste_match_double = l_d;
            this.Nb_match_total += this.nb_match_double + this.Nb_match_simple;
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
            return (this.Nb_joueur() >= this.Nb_j_min);
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
        public void Creation_List_Match(Equipe_competition equipe_b)
        {
            Random generateur = new Random();
            if (Assez_de_joueur() == true)
            {
                for (int n = 0; n < nb_match_simple; n++)
                {
                    int nb = generateur.Next(1, equipe_b.List_joueur_equipe.Count());
                    int na = generateur.Next(1, this.Liste_joueur_ok.Count());
                    Match_simple ma_s = new Match_simple(equipe_b.Liste_joueur_ok[nb], this.Liste_joueur_ok[na]);
                    Liste_match_simple.Add(ma_s);

                    equipe_b.Liste_joueur_ok.Remove(equipe_b.Liste_joueur_ok[nb]);
                    this.Liste_joueur_ok.Remove(this.Liste_joueur_ok[na]);
                }
                for (int a = 0; a < nb_match_double; a++)
                {
                    int nb1 = generateur.Next(1, equipe_b.List_joueur_equipe.Count());
                    int na1 = generateur.Next(1, this.Liste_joueur_ok.Count());
                    int nb2 = generateur.Next(1, equipe_b.List_joueur_equipe.Count());
                    int na2 = generateur.Next(1, this.Liste_joueur_ok.Count());
                    if((nb1!=nb2) && (nb1 != na2))
                    {
                        List<Joueur_competition> l_j1 = new List<Joueur_competition>();
                        l_j1.Add(equipe_b.Liste_joueur_ok[nb1]);
                        l_j1.Add(equipe_b.Liste_joueur_ok[nb2]);

                        List<Joueur_competition> l_j2 = new List<Joueur_competition>();
                        l_j2.Add(this.Liste_joueur_ok[na1]);
                        l_j2.Add(this.Liste_joueur_ok[na2]);

                        Equipe_competition eq1 = new Equipe_competition(l_j1);
                        Equipe_competition eq2 = new Equipe_competition(l_j2);

                        Match_double ma_d = new Match_double(eq1,eq2);
                        equipe_b.Liste_joueur_ok.Remove(equipe_b.Liste_joueur_ok[nb1]);
                        equipe_b.Liste_joueur_ok.Remove(equipe_b.Liste_joueur_ok[nb2]);
                        this.Liste_joueur_ok.Remove(this.Liste_joueur_ok[na1]);
                        this.Liste_joueur_ok.Remove(this.Liste_joueur_ok[na2]);
                        Liste_match_double.Add(ma_d);
                    }
                    
                }
            }
            foreach (Match_simple m in Liste_match_simple)
            {
                int res = generateur.Next(0, 1);
                if (res == 1)
                {
                    m.Joueur_a.Nb_match_jouer++;
                    m.Joueur_b.Nb_match_jouer++;
                    m.Joueur_a.Nb_match_gagner++;
                }
                else
                {
                    m.Joueur_a.Nb_match_jouer++;
                    m.Joueur_b.Nb_match_jouer++;
                    m.Joueur_b.Nb_match_gagner++;
                }
            }
            foreach(Match_double m_d in Liste_match_double)
            {
                int res = generateur.Next(0, 1);
                if (res == 1)
                {
                    m_d.Equipe_a.List_joueur_equipe[0].Nb_match_gagner++;
                    m_d.Equipe_a.List_joueur_equipe[1].Nb_match_gagner++;
                    m_d.Equipe_a.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_a.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_b.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_b.List_joueur_equipe[0].Nb_match_jouer++;
                }
                else 
                {
                    m_d.Equipe_b.List_joueur_equipe[0].Nb_match_gagner++;
                    m_d.Equipe_b.List_joueur_equipe[1].Nb_match_gagner++;
                    m_d.Equipe_a.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_a.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_b.List_joueur_equipe[0].Nb_match_jouer++;
                    m_d.Equipe_b.List_joueur_equipe[0].Nb_match_jouer++;
                }
            }
        }



    }
}
