using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour ResultatClub.xaml
    /// </summary>
    public partial class ResultatClub : Window
    {
        public ResultatClub()
        {
            InitializeComponent();
            Result.Text = aff();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Sattistiques a = new Sattistiques();
            a.Show();
            this.Close();
        }

        private List<Competition_simple> CompetSimple()
        {
            string fichierCompet_individuel = "compet_individuel.txt";
            string[] mots;
            List<Competition_simple> liste_c_i = new List<Competition_simple>();

            string[] lignes = File.ReadAllLines(fichierCompet_individuel);

            for (int i = 0; i < lignes.Length; i++)  //Un retour a la ligne est créé tous le temps donc -1 pour pas sortir de la boucle apres
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Competition_simple compet_indiv = new Competition_simple();
                compet_indiv.Nom = mots[1];
                compet_indiv.Lieu = mots[0];
                compet_indiv.Nb_j_min = int.Parse(mots[2]);
                compet_indiv.Classement_max = double.Parse(mots[3]);

                String list_eq = mots[4];
                String[] j_eq = list_eq.Split('/');
                List<Joueur_competition> list_j = new List<Joueur_competition>();
                for (int j = 0; j < j_eq.Length; j++)
                {
                    Joueur_competition joueur_c = new Joueur_competition(j_eq[j]);
                    list_j.Add(joueur_c);
                }
                compet_indiv.Liste_equipe = list_j;
                compet_indiv.Nb_jours = int.Parse(mots[5]);
                compet_indiv.Nb_match = int.Parse(mots[6]);
                String cat = mots[7];
                String[] cat_l = cat.Split('/');
                compet_indiv.Annee_min = int.Parse(cat_l[0]);
                compet_indiv.Annee_max = int.Parse(cat_l[1]);
                String[] date = mots[8].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);
                compet_indiv.Date = new DateTime(d_a, d_m, d_j);
                liste_c_i.Add(compet_indiv);
            }
            return liste_c_i;
        }
        private List<Competition_equipe> CompetEquipe()
        {
            string fichierCompet_individuel = "compet_equipe.txt";
            string[] mots;
            List<Competition_equipe> liste_c_e = new List<Competition_equipe>();

            string[] lignes = File.ReadAllLines(fichierCompet_individuel);

            for (int i = 0; i < lignes.Length; i++)  //Un retour a la ligne est créé tous le temps donc -1 pour pas sortir de la boucle apres
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Competition_equipe compet_equipe = new Competition_equipe();
                compet_equipe.Nom = mots[1];
                compet_equipe.Lieu = mots[0];
                compet_equipe.Nb_j_min = int.Parse(mots[2]);
                compet_equipe.Classement_max = double.Parse(mots[3]);

                String list_eq = mots[4];
                String[] j_eq = list_eq.Split('/');
                List<Joueur_competition> list_j = new List<Joueur_competition>();
                for (int j = 0; j < j_eq.Length; j++)
                {
                    Joueur_competition joueur_c = new Joueur_competition(j_eq[j]);
                    list_j.Add(joueur_c);
                }
                compet_equipe.Liste_equipe = list_j;
                compet_equipe.Nb_jours = int.Parse(mots[5]);
                compet_equipe.Nb_match_simple = int.Parse(mots[6]);
                compet_equipe.Nb_match_double = int.Parse(mots[7]);
                String cat = mots[8];
                String[] cat_l = cat.Split('/');
                compet_equipe.Annee_min = int.Parse(cat_l[0]);
                compet_equipe.Annee_max = int.Parse(cat_l[1]);
                String[] date = mots[9].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);
                compet_equipe.Date = new DateTime(d_a, d_m, d_j);
                liste_c_e.Add(compet_equipe);
            }
            return liste_c_e;
        }


        public SortedList<int,int> MatchAnnee()
        {
            List<Competition_equipe> list_e = CompetEquipe();
            List<Competition_simple> list_s = CompetSimple();
            SortedList<int, int> matchannee = new SortedList<int, int>();

            int compteur_match = 0;
            int min_annee = 8000;
            int max_annee = 0;
            foreach (Competition_equipe elt in list_e)
            {
                if(elt.Date.Year<min_annee)
                {
                    min_annee = elt.Date.Year;
                }
                else if (elt.Date.Year > max_annee)
                {
                    max_annee = elt.Date.Year;
                }
            }
            foreach (Competition_simple elt in list_s)
            {
                if (elt.Date.Year < min_annee)
                {
                    min_annee = elt.Date.Year;
                }
                else if (elt.Date.Year > max_annee)
                {
                    max_annee = elt.Date.Year;
                }
            }
            for (int i = min_annee; i< max_annee + 1; i++)
            {
                foreach (Competition_equipe elt in list_e)
                {
                    if (elt.Date.Year == i)
                    {
                        compteur_match += elt.Nb_match_simple;
                        compteur_match += elt.Nb_match_double;
                    }
                }
                foreach (Competition_simple elt in list_s)
                {
                    if (elt.Date.Year == i)
                    {
                        compteur_match += elt.Nb_match;
                    }
                }
                matchannee.Add(i, compteur_match);
                compteur_match = 0;
            }
            return matchannee;
        }

        public string aff()
        {
            string afi = "";
            for(int i=0;i<MatchAnnee().Count;i++)
            {
                afi+= Convert.ToString(MatchAnnee().ElementAt(i).Key) +"           "+ Convert.ToString(MatchAnnee().ElementAt(i).Value) + "\n";
            }
            return afi;
        }
    }
}
