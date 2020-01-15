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
    /// Logique d'interaction pour VoirCompet.xaml
    /// </summary>
    public partial class VoirCompet : Window
    {
        public VoirCompet()
        {
            InitializeComponent();
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

                liste_c_i.Add(compet_indiv);
            }

            string affichage = "";
            foreach (Competition_simple c_c in liste_c_i)
            {
                affichage += c_c.ToString() + "\n";
            }
            lise.Text = affichage;
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Competitions a = new Competitions();

            a.Show();
            this.Close();
        }
    }
}
