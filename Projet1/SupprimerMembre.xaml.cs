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
    /// Logique d'interaction pour SupprimerMembre.xaml
    /// </summary>
    public partial class SupprimerMembre : Window
    {
        public SupprimerMembre()
        {
            InitializeComponent();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
        }

        private void supprimer(object sender, RoutedEventArgs e)
        {
            if ((bool)supr_compet.IsChecked)  //On agis sur les joueurs compet
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

                foreach (Joueur_competition j_c in liste_j_c)
                {
                    if (j_c.Nom == supr_nom1.Text && j_c.Prenom == supr_prenom1.Text) 
                    {
                        liste_j_c.Remove(j_c);
                    }
                }

                StreamWriter lire_w = new StreamWriter(fichierMembre_compet);
                foreach (Joueur_competition j in liste_j_c)
                {
                    lire_w.Write("\n" + j.Nom + "," + j.Prenom + "," + j.Naissance.Day + "/" + j.Naissance.Month + "/" + j.Naissance.Year + "," + j.Adresse + "," + j.Telephone + "," + j.Sexe + "," + j.Ville + "," + j.Classement);
                }

                lire_w.Close();
            }

            else if((bool)supr_loisir.IsChecked)   //On agis sur les joueurs loisir
            {
                String[] mots;
                string fichierMembre_loisir = "joueur_loisir.txt";
                

                List<Joueur_loisir> liste_j_l = new List<Joueur_loisir>();

                string[] lignes = File.ReadAllLines(fichierMembre_loisir);
                for (int i = 0; i < lignes.Length - 1; i++)
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

                foreach (Joueur_loisir j_c in liste_j_l)
                {
                    if (j_c.Nom == supr_nom1.Text && j_c.Prenom == supr_prenom1.Text) 
                    {
                            liste_j_l.Remove(j_c);
                        
                    }
                    
                }

                StreamWriter lire_w = new StreamWriter(fichierMembre_loisir);

                foreach (Joueur_loisir j_l in liste_j_l)
                {
                    lire_w.Write("\n" + j_l.Nom + "," + j_l.Prenom + "," + j_l.Naissance.Day + "/" + j_l.Naissance.Month + "/" + j_l.Naissance.Year + "," + j_l.Adresse + "," + j_l.Telephone + "," + j_l.Sexe + "," + j_l.Ville);
                }

                lire_w.Close();
            }
        }
    }
}
