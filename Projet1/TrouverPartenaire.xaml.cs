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
    /// Logique d'interaction pour TrouverPartenaire.xaml
    /// </summary>
    public partial class TrouverPartenaire : Window
    {
        public TrouverPartenaire()
        {
            InitializeComponent();
        }

        private List<Joueur_competition> Liste_joueur_compet()
        {
            String[] mots;
            string fichierMembre_compet = "joueur_compet.txt";
            List<Joueur_competition> liste_j_c = new List<Joueur_competition>();
            string[] lignes = File.ReadAllLines(fichierMembre_compet);
            for (int i = 0; i < lignes.Length; i++)
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Joueur_competition j_compet = new Joueur_competition();
                j_compet.Nom = mots[0];
                j_compet.Prenom = mots[1];
                String[] date = mots[2].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);

                DateTime date_n = new DateTime(d_a, d_m, d_j);
                j_compet.Naissance = (date_n);
                j_compet.Adresse = mots[3];
                j_compet.Telephone = long.Parse(mots[4]);
                if (mots[5] == "F")
                {
                    j_compet.Sexe = true;
                }
                else
                {
                    j_compet.Sexe = false;
                }
                j_compet.Ville = mots[6];
                j_compet.Classement = double.Parse(mots[7]);

                liste_j_c.Add(j_compet);
            }
            return (liste_j_c);
        }
        private List<Joueur_loisir> Liste_joueur_loisir()
        {
            String[] mots;
            string fichierMembre_loisir = "joueur_loisir.txt";
            List<Joueur_loisir> liste_j_l = new List<Joueur_loisir>();
            string[] lignes = File.ReadAllLines(fichierMembre_loisir);
            for (int i = 0; i < lignes.Length; i++)
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Joueur_loisir j_compet = new Joueur_loisir();
                j_compet.Nom = mots[0];
                j_compet.Prenom = mots[1];
                String[] date = mots[2].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);

                DateTime date_n = new DateTime(d_a, d_m, d_j);
                j_compet.Naissance = (date_n);
                j_compet.Adresse = mots[3];
                j_compet.Telephone = long.Parse(mots[4]);
                if (mots[5] == "F")
                {
                    j_compet.Sexe = true;
                }
                else
                {
                    j_compet.Sexe = false;
                }
                j_compet.Ville = mots[6];
                liste_j_l.Add(j_compet);
            }
            return (liste_j_l);
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }

        private void Chercher(object sender, RoutedEventArgs e)
        {
            int d_j = int.Parse(jour.Text);
            int d_m = int.Parse(mois.Text);
            int d_a = int.Parse(annee.Text);
            string nomm = nom.Text;
            string pren = prenom.Text;
            DateTime date_n = new DateTime(d_a, d_m, d_j);
            List<Joueur_loisir> list_j_l = Liste_joueur_loisir();
            List<Joueur_competition> list_j_c = Liste_joueur_compet();
            string affichage = "Joueur competition du meme age : ";
            foreach (Joueur_competition j_c in list_j_c)
            {
                if ((j_c.Naissance.Year == date_n.Year) && (j_c.Nom != nomm) && (j_c.Prenom != pren))
                {
                    affichage += "\n" + j_c.Nom + "  " + j_c.Prenom + "   " +"0" +j_c.Telephone;
                }
            }

            affichage += "\n\n\nJoueur loisir du meme age : ";
            foreach (Joueur_loisir j_l in list_j_l)
            {
                if ((j_l.Naissance.Year == date_n.Year) && (j_l.Nom != nomm) && (j_l.Prenom != pren))
                {
                    affichage += "\n" + j_l.Nom + "  " + j_l.Prenom + "   " +"0"+ j_l.Telephone;
                }
            }
            trouver.Text = affichage;

        }
    }
}
