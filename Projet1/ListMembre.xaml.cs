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
    /// Logique d'interaction pour ListMembre.xaml
    /// </summary>
    public partial class ListMembre : Window
    {

        private List<Joueur_loisir> Liste_joueur_loisir()
        {
            String[] mots;
            string fichierMembre_loisir = "joueur_loisir.txt";
            List<Joueur_loisir> liste_j_l = new List<Joueur_loisir>();

            string[] lignes = File.ReadAllLines(fichierMembre_loisir);
            for (int i = 0; i < lignes.Length; i++)  //Un retour a la ligne est créé tous le temps
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Joueur_loisir j_loisir = new Joueur_loisir();
                j_loisir.Nom = mots[0];
                j_loisir.Prenom = mots[1];
                String[] date = mots[2].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);

                DateTime date_n = new DateTime(d_a, d_m, d_j);
                j_loisir.Naissance = (date_n);
                j_loisir.Adresse = mots[3];
                j_loisir.Telephone = long.Parse(mots[4]);
                if (mots[5] == "F")
                {
                    j_loisir.Sexe = true;
                }
                else
                {
                    j_loisir.Sexe = false;
                }

                j_loisir.Ville = mots[6];
                liste_j_l.Add(j_loisir);
            }
            return (liste_j_l);
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
        public ListMembre()
        {
            InitializeComponent();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();

        }

        private void Nom(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            List<Joueur_loisir> liste_j_l = Liste_joueur_loisir();
            liste_j.Sort();
            liste_j_l.Sort();
            string affichage="Joueur compétition :\n";
            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            affichage += "\n\n Joueur Loisir :\n";
            foreach (Joueur_loisir j_l in liste_j_l)
            {
                affichage += j_l.ToString() + "\n";
            }
            lise.Text = affichage;
        }

        private void Prenom(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            List<Joueur_loisir> liste_j_l = Liste_joueur_loisir();
            liste_j.Sort((x, y) => Membre.CompareP(x, y));
            liste_j_l.Sort((x, y) => Membre.CompareP(x, y));

            string affichage = "Joueur compet \n";

            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            affichage += "\n\n Joueur Loisir :";
            foreach (Joueur_loisir j_l in liste_j_l)
            {
                affichage += j_l.ToString() + "\n";
            }
            lise.Text = affichage;
        }
        private void Sexe(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            List<Joueur_loisir> liste_j_l = Liste_joueur_loisir();
            liste_j.Sort((x, y) => Membre.CompareS(x, y));
            liste_j_l.Sort((x, y) => Membre.CompareS(x, y));

            string affichage = "Joueur compet \n";

            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            affichage += "\n\n Joueur Loisir :";
            foreach (Joueur_loisir j_l in liste_j_l)
            {
                affichage += j_l.ToString() + "\n";
            }
            lise.Text = affichage;
        }
        private void Naissance(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            List<Joueur_loisir> liste_j_l = Liste_joueur_loisir();
            liste_j.Sort((x, y) => Membre.CompareD(x, y));
            liste_j_l.Sort((x, y) => Membre.CompareD(x, y));

            string affichage = "Joueur compet \n";

            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            affichage += "\n\n Joueur Loisir :";
            foreach (Joueur_loisir j_l in liste_j_l)
            {
                affichage += j_l.ToString() + "\n";
            }
            lise.Text = affichage;
        }
        private void Paiement(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            List<Joueur_loisir> liste_j_l = Liste_joueur_loisir();
            liste_j.Sort((x, y) => Membre.ComparePA(x, y));
            liste_j_l.Sort((x, y) => Membre.ComparePA(x, y));

            string affichage = "Joueur compet \n";

            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            affichage += "\n\n Joueur Loisir :";
            foreach (Joueur_loisir j_l in liste_j_l)
            {
                affichage += j_l.ToString() + "\n";
            }
            lise.Text = affichage;
        }

        private void Classement(object sender, RoutedEventArgs e)
        {
            List<Joueur_competition> liste_j = Liste_joueur_compet();
            liste_j.Sort((x, y) => Membre.ComparePA(x, y));

            string affichage = "Joueur compet \n";
            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            lise.Text = affichage;
        }
        private void Competition(object sender, RoutedEventArgs e)
        {
            string affichage = "";
            List<Joueur_competition> liste_j = Liste_joueur_compet();

            foreach (Joueur_competition j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            lise.Text = affichage;

        }
        private void Loisir(object sender, RoutedEventArgs e)
        {
            List<Joueur_loisir> liste_j = Liste_joueur_loisir();
            string affichage = "";
            foreach (Joueur_loisir j_c in liste_j)
            {
                affichage += j_c.ToString() + "\n";
            }
            lise.Text = affichage;

        }

        
    }
}
